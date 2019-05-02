using UnityEngine;
using UnityEngine.UI;
using System;

public class Coordinates : MonoBehaviour {

    public Text NowCoordinates;

    [SerializeField]
    private GameObject MyPlayer;

    void Update () {
        NowCoordinates.text = MyPlayer.transform.position.x + "KIK";
    }
}
