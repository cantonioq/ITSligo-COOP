/*
File            levelBottomCoolider.cs
Author          Antonio Quesnel
Date            24/04/2018 /DD/MM/YYYY  
Version         1.0 
Description:    This script will make the player go to the game
                over scene if touched. The purpose is that this
                script be attached to a ontrigger collider below the 
                level platform floor so if the player falls he will die
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelBottomFallingCoolider : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //this will make the energy go to 0 which a function in 
        //PlayerData.cs will transfer the player to gameOverNoEnergy scene
        //this is done this way since PlayerData will also destroy itself (player data object)
        GameObject.Find("PlayerDATA").GetComponent<PlayerData>().energy = 0;
    }
}
