using UnityEngine;

public class LightCycle : MonoBehaviour {

    //18 min 1 cycle
    private float speed = 0.005f;
        
    public GameObject sunCycle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        sunCycle.transform.Rotate(+speed, 0, 0);
	}
}
