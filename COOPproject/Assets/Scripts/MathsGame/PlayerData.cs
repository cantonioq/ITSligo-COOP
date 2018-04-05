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
        
        if (rightAnswerSwitch == true)
        {
            jumpToken += 1;
            totalRight += 1;
            energy += 1;
            rightAnswerSwitch = false;
        }

        if (wrongAnswerSwitch == true)
        {
            jumpToken -= 1;
            totalWrong += 1;
            wrongAnswerSwitch = false;
        }	
	}

    void DisplayJumpTokens()
    {
        jumpTokensDisplay.text = "Jump Tokens: " + jumpToken.ToString();
    }

    void DisplayEnergy()
    {
        energyDisplay.text = "Energy: " + energy.ToString();
    }

    void DisplayTotalRight()
    {
        totalRightDisplay.text = "Total Right: " + totalRight.ToString();
    }

    void DisplayTotalWrong()
    {
        totalWrongDisplay.text = "Total Wrong: " + totalWrong.ToString();

        //GameObject.Find("UI DATA").GetComponent<uiData>().turbo -= 1.0f;
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
