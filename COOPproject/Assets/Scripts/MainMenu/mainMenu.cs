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
        //this will switch the bool to true for stop music which will notify the 
        //MainMenuMusicPlayer script to destroy itself with the object attach to it to stop the main menu music
        GameObject.Find("MusicPlayer").GetComponent<MainMenuMusicPlayer>().stopMusic = true;
        //sets the difficulty to normal
        PlayerPrefs.SetInt("MathGameDifficulty", 1);
        //will load a random mathScene for the player using mathScene + random
        //e.g. mathScene1, mathScene3 etc...
        SceneManager.LoadScene("loadingScene", LoadSceneMode.Single);
    }

    public void mathematicsDifficultyHard()
    {
        //this will switch the bool to true for stop music which will notify the 
        //MainMenuMusicPlayer script to destroy itself with the object attach to it to stop the main menu music
        GameObject.Find("MusicPlayer").GetComponent<MainMenuMusicPlayer>().stopMusic = true;
        //sets the difficulty to difficult
        PlayerPrefs.SetInt("MathGameDifficulty", 2);
        //will load a random mathScene for the player using mathScene + random
        //e.g. mathScene1, mathScene3 etc...
        SceneManager.LoadScene("loadingScene", LoadSceneMode.Single);
    }

    public void mathematicsDifficultyExpert()
    {
        //this will switch the bool to true for stop music which will notify the 
        //MainMenuMusicPlayer script to destroy itself with the object attach to it to stop the main menu music
        GameObject.Find("MusicPlayer").GetComponent<MainMenuMusicPlayer>().stopMusic = true;
        //sets the diffiuculty to expert
        PlayerPrefs.SetInt("MathGameDifficulty", 3);
        //will load a random mathScene for the player using mathScene + random
        //e.g. mathScene1, mathScene3 etc...
        SceneManager.LoadScene("loadingScene" , LoadSceneMode.Single);
    }





}
