/*
File            titleScreenScript.cs
Author          Antonio Quesnel
Date            02/04/2018  
Version         1.0 
Description:    Simple script that allows the play button on the
                titleScreen to call on this script to load
                the main menu scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreenScript : MonoBehaviour {

    public void startClickButton()
    {
        SceneManager.LoadScene("MathematicsMenu", LoadSceneMode.Single);
    }

    public void creditsClickButton()
    {
        SceneManager.LoadScene("credits", LoadSceneMode.Single);
    }

    public void returnToTitleScreen()
    {
        SceneManager.LoadScene("titleScreen", LoadSceneMode.Single);
    }
}
