﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerNameplate : MonoBehaviour {

    [SerializeField]
    private Text usernameText;

    [SerializeField]
    private RectTransform healthBarFill;

    [SerializeField]
    private Player player;
	
	// Update is called once per frame
	void Update () {
        if(player.username == "EnzoDeg40")
        {
            usernameText.text = "<color=blue>" + player.username + "</color>";
        }
        else
        {
            usernameText.text = player.username;
        }
        
        healthBarFill.localScale = new Vector3(player.GetHealthPct(), 1f, 1f);
	}
}
