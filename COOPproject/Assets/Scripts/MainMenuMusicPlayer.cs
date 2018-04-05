/*
File            MainMenuMusicPlayer.cs
Author          Antonio Quesnel
Date            04/05/2018  
Version         1.0 
Description:    The only goal of this small script is to play the music between the main 
                menu scenes
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusicPlayer : MonoBehaviour {

    public bool stopMusic;

	// Use this for initialization
	void Start () {

        stopMusic = false;
	}
	
	// Update is called once per frame
	void Update ()
    {   
        //if the stopMusic becomes true the object will be desroyed
        //which the music is attached to and thus no more main menu music
        if (stopMusic == true)
        {
            DestroyObject(gameObject);
        }
    }

    void Awake()
    {
        //will play music between main menu scenes
        if (stopMusic == false)
        {
            DontDestroyOnLoad(gameObject);
        }


    }
}
