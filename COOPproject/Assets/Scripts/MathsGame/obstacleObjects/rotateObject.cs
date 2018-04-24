/*
File            rotateObject.cs
Author          Antonio Quesnel
Date            02/04/2018 /DD/MM/YYYY  
Version         1.0 
Description:    a simplt script that when attached to an object
                allows the object to rotate on the x,y and z coordinates
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour {


    public float x;
    public float y;
    public float z;
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);

        transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);

    }
}
