/*
File            newLevelLoader.cs
Author          Antonio Quesnel
Date            02/04/2018 /DD/MM/YYYY  
Version         1.0 
Description:    this script allows an object with the on trigger 
                enabled that when player collides with the object with this script
                that it will load a new scene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevelLoader : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("loadingScene", LoadSceneMode.Single);
    }
}
