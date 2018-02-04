/*
File            MainMenu.cs
Author          Antonio Quesnel
Date            02/04/2018  
Version         1.0 
Description:    Scripts with functions for the onclick buttons 
                in the MainMenu, MathematicsMenu scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    //used for button Mathematics on the Main Menu Scene
    public void mathematicsButton()
    {
        SceneManager.LoadScene("MathematicsMenu", LoadSceneMode.Single);
    }

    //used for buttons in the Mathematics Menu scene
    public void mathematicsAdditionButton()
    {
        PlayerPrefs.SetInt("MathGame", 1);
        SceneManager.LoadScene("MathematicsMenuDifficulty", LoadSceneMode.Single);
    }

    public void mathematicsSubtractionButton()
    {
        PlayerPrefs.SetInt("MathGame", 2);
        SceneManager.LoadScene("MathematicsMenuDifficulty", LoadSceneMode.Single);
    }

    public void mathematicsMultiplicationButton()
    {
        PlayerPrefs.SetInt("MathGame", 3);
        SceneManager.LoadScene("MathematicsMenuDifficulty", LoadSceneMode.Single);
    }

    //used for buttons in the Mathematics Menu Difficulty scene
    public void mathematicsDifficultyNormal()
    {
        PlayerPrefs.SetInt("MathGameDifficulty", 1);
        SceneManager.LoadScene("mathScene1", LoadSceneMode.Single);
    }

    public void mathematicsDifficultyHard()
    {
        PlayerPrefs.SetInt("MathGameDifficulty", 2);
        SceneManager.LoadScene("mathScene1", LoadSceneMode.Single);
    }





}
