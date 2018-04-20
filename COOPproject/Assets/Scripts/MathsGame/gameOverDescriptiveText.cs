/*
File            gameOverDescriptiveText.cs
Author          Antonio Quesnel
Date            16/04/2018  
Version         1.0 
Description:    The purpose of this script is that it grabs the value wrong and the right anwser
                value from PlayerData (using PlayerPrefs) to display on the game over screen
                with the percentage and a grade letter like in school. This makes the UI display
                a "Report Certificate"  to the player.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverDescriptiveText : MonoBehaviour {

    public Text descriptiveText;

    private int rightAnwser;
    private int wrongAnwser;
    private int totalAnwser;

    private int percentage;

    //to display the grade letter value on the screen
    public Text letterGradeText;
    private string letterGrade;


    //just a message that will display depending on the grade letter value
    public Text messageText;
    private string message;



    // Use this for initialization
    void Start () {

        rightAnwser = PlayerPrefs.GetInt("tr");
        wrongAnwser = PlayerPrefs.GetInt("tw");

        totalAnwser = rightAnwser + wrongAnwser;

        percentage = rightAnwser * 100 / totalAnwser;

    }

    void Update()
    {
        displayDescriptiveText();
        displayLetterGrade();
    }

    public void displayDescriptiveText()
    {
        descriptiveText.text = "You got " + rightAnwser + " correct anwsers out of " + totalAnwser + 
            " ,giving you " + percentage + "%. You also got " + GameObject.Find("HighScore DATA").GetComponent<HighScoreData>().playerScore.ToString()
            + "points";
    }

    public void displayLetterGrade()
    {
        if (percentage <= 49)
        {
            letterGrade = "F";
            message = "Don't give up. You'll do better next time!";
        }

        if (percentage >= 50 &&  percentage <= 59)
        {
            letterGrade = "D";
            message = "You passed! Keep it up! By doind this a few more times, you will get your grade up in no time!";
        }

        if (percentage >= 60 && percentage <= 69)
        {
            letterGrade = "C";
            message = "Doing great! Keep it up!";
        }

        if (percentage >= 70 && percentage <= 79)
        {
            letterGrade = "B";
            message = "Wow! You really are becoming the Math wiz!";
        }

        if (percentage >= 80 && percentage <= 89)
        {
            letterGrade = "A";
            message = "Did you study this before playing this game?! Amazing!";
        }

        if (percentage >= 90 && percentage <= 100)
        {
            letterGrade = "A+";
            message = "WOW! You should be teaching this subject!";
        }

        letterGradeText.text = letterGrade;
        messageText.text = message;
    }

}
