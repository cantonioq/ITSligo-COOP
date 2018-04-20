using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverNoEnergyScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mainMenuButton()
    {
        SceneManager.LoadScene("titleScreen", LoadSceneMode.Single);
    }
}
