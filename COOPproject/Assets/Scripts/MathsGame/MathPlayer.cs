/*
File            MathPlayer.cs
Author          Antonio Quesnel
Date            02/04/2018  
Version         1.0 
Description:    script for the automated player movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPlayer : MonoBehaviour {

    private int getMathDifficulty;
    private float playerAutomaticSpeed;

	// Use this for initialization
	void Start () {

        getMathDifficulty = PlayerPrefs.GetInt("MathGameDifficulty");
        //normal difficulty = player moves slower
        if(getMathDifficulty == 1)
        {
            playerAutomaticSpeed = 1;
        }
        //hard difficulty = player moves faster
        if (getMathDifficulty == 2)
        {
            playerAutomaticSpeed = 2;
        }

        Debug.Log("the difficulty value is: " + getMathDifficulty);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
