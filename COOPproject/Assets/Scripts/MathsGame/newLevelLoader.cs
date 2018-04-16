using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerDATA").GetComponent<PlayerData>().levelNumber += 1;

        if (GameObject.Find("PlayerDATA").GetComponent<PlayerData>().energy > 3)
        {
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
        }

        SceneManager.LoadScene("loadingScene", LoadSceneMode.Single);
    }
}
