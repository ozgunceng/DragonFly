using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class RewardedManager : MonoBehaviour
{
    private RewardBasedVideoAd rAd;
    public string id = "";
    public int count = 100;
    public Text coinText;
    public Button rewardButton;

    private void Start()
    {
        rewardButton.interactable = false;
        rAd = RewardBasedVideoAd.Instance;
        rAd.OnAdRewarded += VideoRewarded;
        rAd.OnAdClosed += VideoClosed;


        this.RequestAds();
    }

    private void RequestAds()
    {

        AdRequest request = new AdRequest.Builder().Build();
        this.rAd.LoadAd(request, id);


    }
    private void VideoRewarded(object sender, EventArgs e)
    {
        Reward();


    }
    private void VideoClosed(object sender, EventArgs e)
    {
        RequestAds();


    }

    public void ShowAds()
    {
        this.rAd.Show();

    }


    private void Reward()
    {
        int coin = PlayerPrefs.GetInt("coinkayit");
        coin += count;
        PlayerPrefs.SetInt("coinkayit",coin);
        //coinText.text = coin.ToString();
        coinText.text = "YOU GET 100 COINS SUCCESFULLY";

        rewardButton.interactable = false;

    }

    private void Update()
    {
        if (rAd.IsLoaded())
        {
            rewardButton.interactable = true;
        }
        else
        {
            rewardButton.interactable = false;
        }
    }


}
