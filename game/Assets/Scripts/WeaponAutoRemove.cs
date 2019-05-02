using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAutoRemove : MonoBehaviour {
	
	void Update () {
        if (transform.childCount > 1)
        {
            Destroy(GetComponent<Transform>().GetChild(0).gameObject);
        }
    }
}
