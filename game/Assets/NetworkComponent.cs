using UnityEngine;

public class NetworkComponent : MonoBehaviour {

    [SerializeField]
    Behaviour[] ui;

    void Start () {
	}
	
	void Update () {
        for (int i = 0; i < ui.Length; i++)
        {
            //ui[i].enabled = true;
        }
    }
}
