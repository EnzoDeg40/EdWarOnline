using UnityEngine;

public class Fov : MonoBehaviour {

    [SerializeField]
    private int maxFOV = 110;
    private int minFOV;

    void Start () {
        minFOV = maxFOV / 4;
    }
	
	void Update () {
        // Zoom with right click
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Camera.main.fieldOfView = minFOV;
        }
        else
        {
            Camera.main.fieldOfView = maxFOV;
        }

        // Zoom FOV advenced
        
        if (Input.GetKey(KeyCode.PageUp) && maxFOV < 130)
        {
            maxFOV++;
            Debug.Log(maxFOV);
        }
        if (Input.GetKey(KeyCode.PageDown) && maxFOV > 50)
        {
            maxFOV--;
            Debug.Log(maxFOV);
        }
    }
}
