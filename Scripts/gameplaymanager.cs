using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplaymanager : MonoBehaviour
{


    //=============

    public GameObject hero1;
        public GameObject hero2;
    public GameObject hero3;
    public GameObject hero4;
    public GameObject hero5;
    public GameObject hero6;
    public GameObject hero7;
    public GameObject hero8;
    public GameObject hero9;
    public GameObject hero10;

    void Start()
    {
        if (PlayerPrefs.GetInt("hero1selected") == 0 &&
      PlayerPrefs.GetInt("hero2selected") == 0 &&
                  PlayerPrefs.GetInt("hero3selected") == 0 &&

                  PlayerPrefs.GetInt("hero4selected") == 0 &&

                  PlayerPrefs.GetInt("hero5selected") == 0 &&

                  PlayerPrefs.GetInt("hero6selected") == 0 &&

                  PlayerPrefs.GetInt("hero7selected") == 0 &&

                  PlayerPrefs.GetInt("hero8selected") == 0 &&

                  PlayerPrefs.GetInt("hero9selected") == 0 &&

                  PlayerPrefs.GetInt("hero10selected") == 0)
        {



            PlayerPrefs.SetInt("hero1selected", 1);
            PlayerPrefs.SetInt("hero1unlocked", 1);

        }

    }

    // Update is called once per frame
    void Update()
    {
if(PlayerPrefs.GetInt("hero1selected")==1){
hero1.SetActive(true);

      }
      else{
hero1.SetActive(false);
}

if(PlayerPrefs.GetInt("hero2selected")==1){
hero2.SetActive(true);

      }
      else{
hero2.SetActive(false);
}

if(PlayerPrefs.GetInt("hero3selected")==1){
hero3.SetActive(true);

      }
      else{
hero3.SetActive(false);
}

if(PlayerPrefs.GetInt("hero4selected")==1){
hero4.SetActive(true);

      }
      else{
hero4.SetActive(false);
}

if(PlayerPrefs.GetInt("hero5selected")==1){
hero5.SetActive(true);

      }
      else{
hero5.SetActive(false);
}

if(PlayerPrefs.GetInt("hero6selected")==1){
hero6.SetActive(true);

      }
      else{
hero6.SetActive(false);
}

 if (PlayerPrefs.GetInt("hero7selected") == 1)
        {
            hero7.SetActive(true);

        }
        else
        {
            hero7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hero8selected") == 1)
        {
            hero8.SetActive(true);

        }
        else
        {
            hero8.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hero9selected") == 1)
        {
            hero9.SetActive(true);

        }
        else
        {
            hero9.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hero10selected") == 1)
        {
            hero10.SetActive(true);

        }
        else
        {
            hero10.SetActive(false);
        }



  

        
        
    }
}
