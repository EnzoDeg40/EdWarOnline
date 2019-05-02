using UnityEngine;
using UnityEngine.Networking;

public class PlayerLightManager : NetworkBehaviour
{

    [SerializeField]
    private GameObject lights;

    public void Update()
    {
        if(isLocalPlayer)
        {
            if (Input.GetKeyUp(KeyCode.L))
            {
                lights.SetActive(true);
            }

            if (Input.GetKeyUp(KeyCode.K))
            {
                lights.SetActive(false);
            }
        }
    }
}
