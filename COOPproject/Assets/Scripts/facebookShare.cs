using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class facebookShare : MonoBehaviour {

    private const string FACEBOOK_APP_ID = "161776944535663";
    private const string FACEBOOK_URL = "http://www.facebook.com/dialog/feed";

    void ShareToFacebook(string linkParameter, string nameParameter, string captionParameter, string descriptionParameter, string pictureParameter, string redirectParameter)
    {
        Application.OpenURL(FACEBOOK_URL + "?app_id=" + FACEBOOK_APP_ID +
        "&link=" + WWW.EscapeURL(linkParameter) +
        "&name=" + WWW.EscapeURL(nameParameter) +
        "&caption=" + WWW.EscapeURL(captionParameter) +
        "&description=" + WWW.EscapeURL(descriptionParameter) +
        "&picture=" + WWW.EscapeURL(pictureParameter) +
        "&redirect_uri=" + WWW.EscapeURL(redirectParameter));
    }


    void ShareToFacebookTester(string link, string pic, string name)
    {
        Application.OpenURL(FACEBOOK_URL + "?app_id=" + FACEBOOK_APP_ID +

        "&link=" + WWW.EscapeURL(link) +
        "&picture=" + WWW.EscapeURL(pic) +
        "&name=" + WWW.EscapeURL(name));
    }

    //this function is the one attached to the facebook button in the game
    public void submitToFacebookResults()
    {
        ShareToFacebookTester("http://mysite.com/link-to-my-game", "http://www.bizreport.com/2011/02/03/android-logo-200x200.jpg", "caption" );
        //StartCoroutine(SceneLoadDelay());
    }

    IEnumerator SceneLoadDelay()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("titleScreen");
    }
}
