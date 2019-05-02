using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fov : MonoBehaviour {

    private int minFOV;
    [SerializeField]
    private int maxFOV = 110;

    // Use this for initialization
    void Start () {
        minFOV = maxFOV / 4;
    }
	
	// Update is called once per frame
	void Update () {
        // Zoom A
        if (Input.GetKeyDown(KeyCode.A))
        {
            Camera.main.fieldOfView = minFOV;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Camera.main.fieldOfView = maxFOV;
        }

        // Zoom FOV advenced
        /*
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            maxFOV = maxFOV + 1;
            Debug.Log(maxFOV);
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            if (maxFOV >= 120)
            {
                Camera.main.fieldOfView = 120;
            }
            maxFOV = maxFOV - 1;
            Debug.Log(maxFOV);
        }
        */


        

    

    }
}
