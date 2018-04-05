/*
File            RandomMusicPlayer.cs
Author          Antonio Quesnel
Date            04/05/2018  
Version         1.0 
Description:    A simple script that allows to play a random music file
                everytime.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusicPlayer : MonoBehaviour {

    public AudioSource audio;
    public AudioClip[] myMusic;

    // Use this for initialization
    void Start () {
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (!audio.isPlaying)
            playRandomMusic();
    }

    void playRandomMusic()
    {
        audio.clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        audio.Play();
    }
}
