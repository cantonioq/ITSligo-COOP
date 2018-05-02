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

    public void twitterPostTitleScreen()
    {
        ShareToTwitter("Math Takedown at the windows store. Learn Maths the fun way at http://www.antonioq.com/math-takedown/");
    }

    public void twitterPostGameOverScreen()
    {
        ShareToTwitter("okokok" + TWEET_LANGUAGE);
    }
}
