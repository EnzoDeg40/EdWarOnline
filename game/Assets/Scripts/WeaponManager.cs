using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class WeaponManager : NetworkBehaviour {

    [SerializeField]
    private string weaponLayerName = "Weapon";

    [SerializeField]
    private Transform weaponHolder;

    [SerializeField]
    private PlayerWeapon primaryWeapon;
    [SerializeField]
    private PlayerWeapon secondWeapon;
    [SerializeField]
    private PlayerWeapon thirdWeapon;
    [SerializeField]
    private PlayerWeapon sniperWeapon;

    private PlayerWeapon currentWeapon;
    private WeaponGraphics currentGraphics;

    public bool isReloading = false;

    private int currentArm;

	void Start () {
        EquipWeapon(primaryWeapon);
        currentArm = 2;
	}

    private void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyUp(KeyCode.E) && currentArm == 1 || Input.GetKeyUp(KeyCode.Alpha1) || Input.GetMouseButtonDown(4) && currentArm == 1)
            {
                EquipWeapon(primaryWeapon);
                currentArm++;
            }
            else{
                if (Input.GetKeyUp(KeyCode.E) && currentArm == 2 || Input.GetKeyUp(KeyCode.Alpha2) || Input.GetMouseButtonDown(4) && currentArm == 2)
                {
                    EquipWeapon(secondWeapon);
                    currentArm++;
                }
                else
                {
                    if (Input.GetKeyUp(KeyCode.E) && currentArm == 3 || Input.GetKeyUp(KeyCode.Alpha3) || Input.GetMouseButtonDown(4) && currentArm == 3)
                    {
                        EquipWeapon(thirdWeapon);
                        currentArm++;
                    }
                    else
                    {
                        if (Input.GetKeyUp(KeyCode.E) && currentArm == 4 || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetMouseButtonDown(4) && currentArm == 4)
                        {
                            EquipWeapon(sniperWeapon);
                            currentArm = 1;
                        }
                    }
                }
            }
        }

    }


    public PlayerWeapon GetCurrentWeapon()
    {
        return currentWeapon;
    }

    public WeaponGraphics GetCurrentGraphics()
    {
        return currentGraphics;
    }

    void EquipWeapon(PlayerWeapon _weapon)
    {
        currentWeapon = _weapon;

        GameObject _weaponIns = (GameObject)Instantiate(_weapon.graphics, weaponHolder.position, weaponHolder.rotation);
        _weaponIns.transform.SetParent(weaponHolder);

        currentGraphics = _weaponIns.GetComponent<WeaponGraphics>();
        if(currentGraphics == null)
        {
            Debug.LogError("Pas de script WeaponGraphics sur l'arme: " + _weaponIns.name);
        }

        if (isLocalPlayer)
        {
            Util.SetLayerRecursively(_weaponIns, LayerMask.NameToLayer(weaponLayerName));
        }
    }

    public void Reload()
    {
        if(isReloading == true)
        {
            return;
        }

        StartCoroutine(Reload_Coroutine());
    }

    public IEnumerator Reload_Coroutine()
    {
        Debug.Log("Reloading...");

        isReloading = true;

        CmdOnReload();

        yield return new WaitForSeconds(currentWeapon.reloadTime);

        currentWeapon.bullets = currentWeapon.maxBullets;

        isReloading = false;

        Debug.Log("Finished reloading.");
    }

    [Command]
    void CmdOnReload()
    {
        RpcOnReload();
    }

    [ClientRpc]
    void RpcOnReload()
    {
        Animator anim = currentGraphics.GetComponent<Animator>();
        if(anim != null)
        {
            anim.SetTrigger("Reload");
        }
    }

}
