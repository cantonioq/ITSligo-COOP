/*
File            MathGameSelector.cs
Author          Antonio Quesnel
Date            02/04/2018  
Version         1.0 
Description:    takes the playerprefs value and select the approriate game
                e.g. addition, multiplication etc...
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathGameSelector : MonoBehaviour {
    //variable for game type, Addition, Substration or Multiplication
    private int getMathGame;
    //Difficulty of the game, if difficulty higher, harder numbers to calculate
    private int getMathDifficulty;
    private bool newQuestion = false;

    public Text displayQuestion;
    public Text answer; //for testing will be removed
    public Text rightWrongText;

    public InputField inputFieldAnswer;

    private int valueOne;
    private int valueTwo;
    private int valueTotal;
    int inputIntConvert;
    string plusAddMultiVariable;

    string gotWrongMessage;
    string[] gotWrong = { "bad", "Not good" };

    string gotRightMessage;
    string[] gotRight = { "ok", "good"};
    // Use this for initialization
    void Start ()
    {
        getMathGame = PlayerPrefs.GetInt("MathGame");
        getMathDifficulty = PlayerPrefs.GetInt("MathGameDifficulty");
        Calculator();		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //will take a random string and display it when the player gets the right answer
        gotRightMessage = gotRight[Random.Range(0, gotRight.Length)];
        //will take a random string and display it when the player gets the right answer
        gotWrongMessage = gotWrong[Random.Range(0, gotRight.Length)];

        if (newQuestion == true)
        {
            Calculator();
        }
        displayQuestion.text = valueOne.ToString() + plusAddMultiVariable + valueTwo.ToString();
        answer.text = valueTotal.ToString();//for debuging will be removed later       
    }

    private void MathGameDifficulty()
    {
        if(getMathDifficulty == 1)
        {
            valueOne = Random.Range(1, 10);
            valueTwo = Random.Range(1, 10);
        }

        if (getMathDifficulty == 2)
        {
            valueOne = Random.Range(-1, 50);
            valueTwo = Random.Range(-1, 50);
        }

        if (getMathDifficulty == 3)
        {
            valueOne = Random.Range(-100, 100);
            valueTwo = Random.Range(-100, 100);
        }
    }

    public void Calculator()
    {
        newQuestion = false;
        inputIntConvert = int.Parse(inputFieldAnswer.text); //for integer 
        inputFieldAnswer.text = ""; //Clear Inputfield text
        inputFieldAnswer.ActivateInputField(); //Re-focus on the input field
        inputFieldAnswer.Select();//Re-focus on the input field

        if (inputIntConvert == valueTotal)
        {
            //displays a message that player got the answer right
            rightWrongText.text = gotRightMessage;
        }

        else
        {
            //displays a message that the player got the answer wrong
            rightWrongText.text = gotWrongMessage;
        }

        if (getMathGame == 1)
        {
            plusAddMultiVariable = " + ";
            MathGameDifficulty();
            valueTotal = valueOne + valueTwo;
        }

        if(getMathGame == 2)
        {
            plusAddMultiVariable = " - ";
            MathGameDifficulty();
            valueTotal = valueOne - valueTwo;
        }

        if(getMathGame == 3)
        {
            plusAddMultiVariable = " * ";
            MathGameDifficulty();
            valueTotal = valueOne * valueTwo;
        }
        newQuestion = true;
    }

    void OnEnable()
    {
        //Register InputField Events
        inputFieldAnswer.onEndEdit.AddListener(delegate { Calculator(); });
    }

    void OnDisable()
    {
        //Un-Register InputField Events
        inputFieldAnswer.onEndEdit.RemoveAllListeners();
        inputFieldAnswer.onValueChanged.RemoveAllListeners();
    }

}
