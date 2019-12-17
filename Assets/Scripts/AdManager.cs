using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get; }

    public string bannerID;
    public string videoID;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

#if UNITY_EDITOR
        Debug.Log("Your In the editor, play it on android for it to work");
#elif UNITY_ANDROID
        Admob.Instance().initAdmob(bannerID, videoID);
        Admob.Instance().loadInterstitial();
#endif
    }

    public void ShowBanner()
    {
#if UNITY_EDITOR
        Debug.Log("Your In the editor, play it on android for it to work");
#elif UNITY_ANDROID
        Admob.Instance().showBannerAbsolute(AdSize.Banner, AdPosition.BOTTOM_RIGHT, 5);
#endif
    }

    public void ShowVideo()
    {
#if UNITY_EDITOR
        Debug.Log("Your In the editor, play it on android for it to work");
#elif UNITY_ANDROID
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
#endif
    }
}
