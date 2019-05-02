using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    [SerializeField]
    private Camera CameraPlayer;

    private bool KeyPress = false;

	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            KeyPress = true;
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.C))
            {
                KeyPress = false;
            }
        }

        if (KeyPress == true)
        {
            CameraPlayer.transform.position = new Vector3(0f, 1.5f, -2f);
        }
        else
        {
            CameraPlayer.transform.position = new Vector3(0f, 0.35f, 0f);
        }
    }
}
