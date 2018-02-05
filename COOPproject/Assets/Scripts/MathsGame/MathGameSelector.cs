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

    private int getMathGame;
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

        if (getMathGame == 1)
        {
            if (inputIntConvert == valueTotal)
                {
                    Debug.Log("Right Answer");
                rightWrongText.text = "Way to go!";
                }

            else
                {
                    Debug.Log("SORRY inputAwnser: " + inputIntConvert + "  valueTotal: " + valueTotal);
                    rightWrongText.text = "oh no!";
                }

            plusAddMultiVariable = " + ";
            MathGameDifficulty();
            valueTotal = valueOne + valueTwo;
        }

        if(getMathGame == 2)
        {
            if (inputIntConvert == valueTotal)
            {
                Debug.Log("Right Answer");
                rightWrongText.text = "way to go";
            }

            else
            {
                Debug.Log("SORRY inputAwnser: " + inputIntConvert + "  valueTotal: " + valueTotal);
                rightWrongText.text = "oh no!";
            }

            plusAddMultiVariable = " - ";
            MathGameDifficulty();
            valueTotal = valueOne - valueTwo;
        }

        if(getMathGame == 3)
        {
            if (inputIntConvert == valueTotal)
            {
                Debug.Log("Right Answer");
                rightWrongText.text = "way to go";
            }

            else
            {
                Debug.Log("SORRY inputAwnser: " + inputIntConvert + "  valueTotal: " + valueTotal);
                rightWrongText.text = "oh no!";
            }

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
