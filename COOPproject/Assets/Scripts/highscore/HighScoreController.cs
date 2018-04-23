/*
File            HighScoreController.cs
Author          Antonio Quesnel
Date            19/04/2018  
Version         1.0 
Description:    This scripts purpose is to allow players to post their score
                to the online database
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreController : MonoBehaviour {

    public InputField playerName;

    public Text displayScore;

    private string secretKey = "dsjhdjshdsvf443847386sds7d67kjkajskab67637236ddsd"; // Edit this value and make sure it's the same as the one stored on the server
    public string addScoreURL = "http://antonioq.com/mathtakedown/addscore.php?"; //be sure to add a ? to your url
    public string highscoreURL = "http://antonioq.com/mathtakedown/display.php";

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "highScore")
        {
            StartCoroutine(GetScores());
        }
        //StartCoroutine(GetScores());
    }

    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');
    }

    // remember to use StartCoroutine when calling this function!
    IEnumerator PostScores(string name, int score)
    {
        //This connects to a server side php script that will add the name and score to a MySQL DB.
        // Supply it with a string representing the players name and the players score.
        string hash = Md5Sum(name + score + secretKey);
        Debug.Log(hash);

        string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;

        // Post the URL to the site and create a download object to get the result.
        WWW hs_post = new WWW(post_url);
        yield return hs_post; // Wait until the download is done

        if (hs_post.error != null)
        {
            print("There was an error posting the high score: " + hs_post.error);
        }
    }

    public void SubmitScore()
    {
        StartCoroutine(PostScores(playerName.text, GameObject.Find("HighScore DATA").GetComponent<HighScoreData>().playerScore));
        Debug.Log("going");
        StartCoroutine(SceneLoadDelay());
    }

    IEnumerator SceneLoadDelay()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("titleScreen");
    }


    public void GetTheScores()
    {
        StartCoroutine(GetScores());
    }

    // Get the scores from the MySQL DB to display in a GUIText.
    // remember to use StartCoroutine when calling this function!
    IEnumerator GetScores()
    {
        //gameObject.GetComponent<GUIText>().text = "Loading Scores";

        displayScore.text = "loading...";
        WWW hs_get = new WWW(highscoreURL);
        yield return hs_get;

        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            //gameObject.GetComponent<GUIText>().text = hs_get.text; // this is a GUIText that will display the scores in game.

            displayScore.text = hs_get.text;

        }
    }

}
