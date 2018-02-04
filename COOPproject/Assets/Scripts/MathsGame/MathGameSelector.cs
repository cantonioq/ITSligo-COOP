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

    private bool MathGameAdd = false;
    private bool MathGameSub = false;
    private bool MathGameMulti = false;
    private int getMathGame;

    private bool newQuestion = true;

    public Text displayQuestion;
    //public string displayOnUItext;

    public InputField inputFieldAnswer;

    private int valueOne;
    private int valueTwo;
    private int valueTotal;
    int inputIntConvert;

    // Use this for initialization
    void Start () {

        getMathGame = PlayerPrefs.GetInt("MathGame");

        if(getMathGame == 1)
        {
            MathGameAdd = true;
        }

        if(getMathGame == 2)
        {
            MathGameSub = true;
        }

        if(getMathGame == 3)
        {
            MathGameMulti = true;
        }

        Debug.Log("the Mathgame value is: " + getMathGame);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (newQuestion == true)
        {
            Calculator();
        }
        
	}


    public void Calculator()
    {

        if (MathGameAdd == true)
        {
            newQuestion = false;
            valueOne = Random.Range(-50, 100);
            valueTwo = Random.Range(-50, 100);
            valueTotal = valueOne + valueTwo;
            Debug.Log("ok");

            displayQuestion.text = valueOne.ToString() + " + " + valueTwo.ToString();

            //if(Input.GetKeyDown("enter"))
            //{
                if (inputIntConvert == valueTotal)
                {
                    displayQuestion.text = "yes!!";
                        Debug.Log("YES");
                }

                else
                {
                    displayQuestion.text = "SORRY";
                }
            //}


        }

        if(MathGameSub == true)
        {

        }

        if(MathGameMulti == true)
        {

        }
        //newQuestion = true;
    }

    //the code below is to grab the input from the textbox
    private void inputSubmitAnswer()
    {
        inputIntConvert = int.Parse(inputFieldAnswer.text); //for integer 
        Debug.Log("Input Submitted" + inputFieldAnswer.text + "::::  " + inputIntConvert );
        inputFieldAnswer.text = ""; //Clear Inputfield text
        inputFieldAnswer.ActivateInputField(); //Re-focus on the input field
        inputFieldAnswer.Select();//Re-focus on the input field

        

    }

    void OnEnable()
    {
        //Register InputField Events
        inputFieldAnswer.onEndEdit.AddListener(delegate { inputSubmitAnswer(); });
    }

    void OnDisable()
    {
        //Un-Register InputField Events
        inputFieldAnswer.onEndEdit.RemoveAllListeners();
        inputFieldAnswer.onValueChanged.RemoveAllListeners();
    }
}
