using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeNow : MonoBehaviour {

    public Text NowTime;

    void Update () {
        NowTime.text = DateTime.Now.ToString("HH:mm");
    }
}
