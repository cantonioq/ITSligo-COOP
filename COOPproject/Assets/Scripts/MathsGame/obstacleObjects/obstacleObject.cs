/*
File            obstacleObject.cs
Author          Antonio Quesnel
Date            02/04/2018 /DD/MM/YYYY  
Version         1.0 
Description:    this script allows an object with the on trigger 
                enabled to remove on energy point from player if the player
                touches this object.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("PlayerDATA").GetComponent<PlayerData>().energy -= 1;
        }
    }
}
