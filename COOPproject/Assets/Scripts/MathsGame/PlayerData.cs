/*
File            PlayerData.cs
Author          Antonio Quesnel
Date            04/05/2018  
Version         1.0 
Description:    This script keeps the data for variables when moving 
                from one scene to the next, or until game over
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour {

    public Text jumpTokensDisplay;
    public int jumpToken;

    public Text energyDisplay;
    public int energy;

    public Text totalRightDisplay;
    public int totalRight;

    public Text totalWrongDisplay;
    public int totalWrong;

    public bool rightAnswerSwitch;
    public bool wrongAnswerSwitch;

    public Text displayTimer;
    public float timer;

    //this variable for the awake function which allows the object which this 
    //script is attached to does not get destroyed when player goes into next scene
    public static PlayerData holder;

    // Use this for initialization
    void Start ()
    {
        jumpToken = 1;
        energy = 3;
        totalRight = 0;
        totalWrong = 0;
        timer = 60;

        rightAnswerSwitch = false;
        wrongAnswerSwitch = false;        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        DisplayJumpTokens();
        DisplayEnergy();
        DisplayTotalRight();
        DisplayTotalWrong();
        DisplayTimer();


        if (rightAnswerSwitch == true)
        {
            jumpToken += 1;
            totalRight += 1;
            energy += 1;
            rightAnswerSwitch = false;
            timer += 2;
        }

        if (wrongAnswerSwitch == true)
        {
            jumpToken -= 1;
            totalWrong += 1;
            wrongAnswerSwitch = false;
        }	
	}

    void DisplayTimer()
    {
        displayTimer.text = "Time left: " + timer.ToString("00");
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
            Destroy(gameObject);
        }
    }

    void DisplayJumpTokens()
    {
        jumpTokensDisplay.text = "Jump Tokens: " + jumpToken.ToString();
    }

    void DisplayEnergy()
    {
        energyDisplay.text = "Energy: " + energy.ToString();
        if (energy < 1)
        {
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
            Destroy(gameObject);
        }

        if (energy > 5)
        {
            energy = 5;
        }
    }

    void DisplayTotalRight()
    {
        totalRightDisplay.text = "Total Right: " + totalRight.ToString();
    }

    void DisplayTotalWrong()
    {
        totalWrongDisplay.text = "Total Wrong: " + totalWrong.ToString();
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
