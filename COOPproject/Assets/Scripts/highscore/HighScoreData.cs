/*
File            HighScoreData.cs
Author          Antonio Quesnel
Date            20/04/2018  
Version         1.0 
Description:    This script keeps the score that the player
                has achieved in a object that goes from scene
                to scene without being destroyed.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreData : MonoBehaviour {

    //this variable for the awake function which allows the object which this 
    //script is attached to does not get destroyed when player goes into next scene
    public static HighScoreData holder;

    public int playerScore;

    // Use this for initialization
    void Start () {
        playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (SceneManager.GetActiveScene().name == "highScore" ||
            SceneManager.GetActiveScene().name == "titleScreen" )
        {
            Destroy(gameObject);
        }
		
	}

    void Awake()
    {
        if (holder == null)
        {
            DontDestroyOnLoad(gameObject);
            holder = this;
        }

        else if (holder != this)
        {
            Destroy(gameObject);
        }

    }
}
