using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleMobileAdsDemoScript : MonoBehaviour
{
    public RewardedAd rewardedAd;

    public void Start()
    {
        string adUnitId;
#if UNITY_ANDROID
            adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
        adUnitId = "unexpected_platform";
#endif
        this.rewardedAd = new RewardedAd(adUnitId);



        AdRequest request = new AdRequest.Builder().Build();

        this.rewardedAd.LoadAd(request);
    }
}