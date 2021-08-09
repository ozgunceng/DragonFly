using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DailyReward : MonoBehaviour
{

    public string url = "www.google.com";
    public string urlDate = "http://worldclockapi.com/api/json/est/now";
    public string sDate = "";
    public bool delete;

    public Text coinText;
    public List<int> rewardCoin;
    public List<Button> rewardButton;
    public Button dailyButton;
    public GameObject dailyPanel;

    public void  Start()
    {
        if (delete)
            PlayerPrefs.DeleteAll();

        coinText.text = PlayerPrefs.GetInt("coinkayit").ToString();
        StartCoroutine(CheckInternet());
    }


    private IEnumerator CheckInternet()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();
            if (!webRequest.isNetworkError)
            {
                Debug.Log("Success Internet");
                StartCoroutine(CheckDate());
            }
        }


    }
    private IEnumerator CheckDate()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(urlDate))
        {
            yield return webRequest.SendWebRequest();
            if (!webRequest.isNetworkError)
            {
                string[] splitDate = webRequest.downloadHandler.text.Split(new string[] { "currentDateTime\":\"" }, StringSplitOptions.None);
                sDate = splitDate[1].Substring(0, 10);

            }
        }
        Debug.Log(sDate);
       dailyButton.interactable = true;
    }



    public void DailyCheck()
    {

        string dateOld = PlayerPrefs.GetString("PlayDateOld");

        if (string.IsNullOrEmpty(dateOld))
        {
            Debug.Log("First Game");
            Debug.Log("First Award");
            //Reward(0);
            rewardButton[0].interactable = true;
            PlayerPrefs.SetString("PlayDateOld", sDate);
            PlayerPrefs.SetInt("PlayGameCount", 1);
        }
        else
        {

            DateTime _dateNow = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime _dateOld = Convert.ToDateTime(dateOld);

            TimeSpan diff = _dateNow.Subtract(_dateOld);
            if (diff.Days >= 1 && diff.Days < 2)
            {
                int gameCount = PlayerPrefs.GetInt("PlayGameCount");
                if (gameCount == 1)
                {
                    rewardButton[1].interactable = true;

                   // Reward(1);
                    PlayerPrefs.SetInt("PlayGameCount", 2);
                }
                else if (gameCount == 2)
                {
                    rewardButton[2].interactable = true;

                    //Reward(2);
                }
                Debug.Log("Other Days");
             
                PlayerPrefs.SetString("PlayDateOld", _dateNow.ToString());

            }
            else if(diff.Days >= 2)
            {
                rewardButton[0].interactable = true;

                //Reward(0);
                PlayerPrefs.SetInt("PlayGameCount", 1);

                PlayerPrefs.SetString("PlayDateOld", _dateNow.ToString());

            }

        }

    }

    public void Reward(int count)
    {
        int coin = PlayerPrefs.GetInt("coinkayit");
        coin += rewardCoin[count];
        PlayerPrefs.SetInt("coinkayit", coin);
        coinText.text = coin.ToString();
        Button clickButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        clickButton.interactable = false;

    }

    public void DailyPanel()
    {
        dailyPanel.SetActive(true);
    }

}
