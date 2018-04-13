using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twitterShare : MonoBehaviour {


    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    private const string TWEET_LANGUAGE = "en";

    void ShareToTwitter(string textToDisplay)
    {
        Application.OpenURL(TWITTER_ADDRESS +
                    "?text=" + WWW.EscapeURL(textToDisplay) +
                    "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }

    public void twitterPost()
    {
        ShareToTwitter("okokok" + TWEET_LANGUAGE);
    }
}
