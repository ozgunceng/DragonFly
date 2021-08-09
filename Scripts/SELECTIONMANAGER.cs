using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SELECTIONMANAGER : MonoBehaviour
{
    // Start is called before the first frame update
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

    public int HEROCODENAME=1;

    public int coins;

    public Text coinstxt;
    public Text menucointxt;

    //=====================

    public int HERO_1_PRICE;
            public int HERO_2_PRICE;
    public int HERO_3_PRICE;
    public int HERO_4_PRICE;
    public int HERO_5_PRICE;
    public int HERO_6_PRICE;
    public int HERO_7_PRICE;
    public int HERO_8_PRICE;
    public int HERO_9_PRICE;
    public int HERO_10_PRICE;

    //----------------------
    public Text PRICEOFHEROTXT;

    public GameObject buybutton;
        public GameObject SELECTBUTTON;

        public GameObject locked;
        public GameObject selected;

//------------------------




    void Start()
    {
        HEROCODENAME=1;
        coins=200;
        //---------------
        // if (selected==false)



        if (PlayerPrefs.GetInt("hero1selected") == 0 &&
            PlayerPrefs.GetInt("hero2selected") == 0 &&
                        PlayerPrefs.GetInt("hero3selected") == 0 &&

                        PlayerPrefs.GetInt("hero4selected") == 0 &&

                        PlayerPrefs.GetInt("hero5selected") == 0 &&

                        PlayerPrefs.GetInt("hero6selected") == 0 &&

                        PlayerPrefs.GetInt("hero7selected") == 0 &&

                        PlayerPrefs.GetInt("hero8selected") == 0 &&

                        PlayerPrefs.GetInt("hero9selected") == 0 &&

                        PlayerPrefs.GetInt("hero10selected") == 0 ) {



            PlayerPrefs.SetInt("hero1selected", 1);
            PlayerPrefs.SetInt("hero1unlocked", 1);

        }
      

        
    }

    // Update is called once per frame

    void Update()

    {

       


        if (HEROCODENAME==1){
    if(PlayerPrefs.GetInt("hero1selected")==1){

        selected.SetActive(true);

}
 
}
if(HEROCODENAME==2){
    if(PlayerPrefs.GetInt("hero2selected")==1){

        selected.SetActive(true);

}
 
}
if(HEROCODENAME==3){
    if(PlayerPrefs.GetInt("hero3selected")==1){

        selected.SetActive(true);

}
 
}
if(HEROCODENAME==4){
    if(PlayerPrefs.GetInt("hero4selected")==1){

        selected.SetActive(true);

}
 
}
if(HEROCODENAME==5){
    if(PlayerPrefs.GetInt("hero5selected")==1){

        selected.SetActive(true);

}
 
}
if(HEROCODENAME==6){
    if(PlayerPrefs.GetInt("hero6selected")==1){

        selected.SetActive(true);

}
 
}
        if (HEROCODENAME == 7)
        {
            if (PlayerPrefs.GetInt("hero7selected") == 1)
            {

                selected.SetActive(true);

            }

        }
        if (HEROCODENAME == 8)
        {
            if (PlayerPrefs.GetInt("hero8selected") == 1)
            {

                selected.SetActive(true);

            }

        }
        if (HEROCODENAME == 9)
        {
            if (PlayerPrefs.GetInt("hero9selected") == 1)
            {

                selected.SetActive(true);

            }

        }
        if (HEROCODENAME == 10)
        {
            if (PlayerPrefs.GetInt("hero10selected") == 1)
            {

                selected.SetActive(true);

            }

        }


        //===========================

        if (buybutton.activeInHierarchy==true){
                SELECTBUTTON.SetActive(false);


        }
        else{
                            SELECTBUTTON.SetActive(true);



        }

        if(PlayerPrefs.GetInt("hero1unlocked")==1){

            if(HEROCODENAME==1){

                buybutton.SetActive(false);
locked.SetActive(false);
            }
           


        }
        if(PlayerPrefs.GetInt("hero2unlocked")==1){
  if(HEROCODENAME==2){

                buybutton.SetActive(false);
locked.SetActive(false);
            }

        }
        if(PlayerPrefs.GetInt("hero3unlocked")==1){
 if(HEROCODENAME==3){

                buybutton.SetActive(false);
locked.SetActive(false);
            }

        }
        if(PlayerPrefs.GetInt("hero4unlocked")==1){
 if(HEROCODENAME==4){

                buybutton.SetActive(false);
locked.SetActive(false);
            }
        }
        if(PlayerPrefs.GetInt("hero5unlocked")==1){
 if(HEROCODENAME==5){

                buybutton.SetActive(false);
locked.SetActive(false);
            }

        }
        if(PlayerPrefs.GetInt("hero6unlocked")==1){
 if(HEROCODENAME==6){

                buybutton.SetActive(false);
locked.SetActive(false);
            }
        }
  if (PlayerPrefs.GetInt("hero7unlocked") == 1)
        {
            if (HEROCODENAME == 7)
            {

                buybutton.SetActive(false);
                locked.SetActive(false);
            }
        }

        if (PlayerPrefs.GetInt("hero8unlocked") == 1)
        {
            if (HEROCODENAME == 8)
            {

                buybutton.SetActive(false);
                locked.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("hero9unlocked") == 1)
        {
            if (HEROCODENAME == 9)
            {

                buybutton.SetActive(false);
                locked.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("hero10unlocked") == 1)
        {
            if (HEROCODENAME == 10)
            {

                buybutton.SetActive(false);
                locked.SetActive(false);
            }
        }





        if (HEROCODENAME==1){
            PRICEOFHEROTXT.text=HERO_1_PRICE.ToString();
        }
         if(HEROCODENAME==2){
            PRICEOFHEROTXT.text=HERO_2_PRICE.ToString();
        }
         if(HEROCODENAME==3){
            PRICEOFHEROTXT.text=HERO_3_PRICE.ToString();
        }
        if(HEROCODENAME==4){
            PRICEOFHEROTXT.text=HERO_4_PRICE.ToString();
        }
        if(HEROCODENAME==5){
            PRICEOFHEROTXT.text=HERO_5_PRICE.ToString();
        }
        if(HEROCODENAME==6){
            PRICEOFHEROTXT.text=HERO_6_PRICE.ToString();
        }

        if (HEROCODENAME == 7)
        {
            PRICEOFHEROTXT.text = HERO_7_PRICE.ToString();
        }
        if (HEROCODENAME == 8)
        {
            PRICEOFHEROTXT.text = HERO_8_PRICE.ToString();
        }
        if (HEROCODENAME == 9)
        {
            PRICEOFHEROTXT.text = HERO_9_PRICE.ToString();
        }
        if (HEROCODENAME == 10)
        {
            PRICEOFHEROTXT.text = HERO_10_PRICE.ToString();
        }


        coinstxt.text=PlayerPrefs.GetInt("coinkayit").ToString();
        //--------------------------------
      


        
        if(HEROCODENAME==1){

hero1.SetActive(true);
hero2.SetActive(false);
hero3.SetActive(false);
hero4.SetActive(false);
hero5.SetActive(false);
hero6.SetActive(false);
hero7.SetActive(false);
hero8.SetActive(false);
hero9.SetActive(false);
hero10.SetActive(false);



        }
         if(HEROCODENAME==2){

hero1.SetActive(false);
hero2.SetActive(true);
hero3.SetActive(false);
hero4.SetActive(false);
hero5.SetActive(false);
hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
         if(HEROCODENAME==3){

hero1.SetActive(false);
hero2.SetActive(false);
hero3.SetActive(true);
hero4.SetActive(false);
hero5.SetActive(false);
hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
         if(HEROCODENAME==4){

hero1.SetActive(false);
hero2.SetActive(false);
hero3.SetActive(false);
hero4.SetActive(true);
hero5.SetActive(false);
hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
         if(HEROCODENAME==5){

hero1.SetActive(false);
hero2.SetActive(false);
hero3.SetActive(false);
hero4.SetActive(false);
hero5.SetActive(true);
hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
         if(HEROCODENAME==6){

hero1.SetActive(false);
hero2.SetActive(false);
hero3.SetActive(false);
hero4.SetActive(false);
hero5.SetActive(false);
hero6.SetActive(true);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);


        }

        if (HEROCODENAME == 7)
        {

            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
            hero6.SetActive(false);
            hero7.SetActive(true);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
        if (HEROCODENAME == 8)
        {

            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
            hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(true);
            hero9.SetActive(false);
            hero10.SetActive(false);



        }
        if (HEROCODENAME == 9)
        {

            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
            hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(true);
            hero10.SetActive(false);



        }
        if (HEROCODENAME == 10)
        {

            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
            hero6.SetActive(false);
            hero7.SetActive(false);
            hero8.SetActive(false);
            hero9.SetActive(false);
            hero10.SetActive(true);



        }
    }

    public void LEFT(){
                selected.SetActive(false);



        //================================
        if(HEROCODENAME!=1){

            HEROCODENAME--;
             buybutton.SetActive(true);
locked.SetActive(true);
        }


    }
    public void RIGHT(){

                        selected.SetActive(false);

        if(HEROCODENAME!=10){

            HEROCODENAME++;
             buybutton.SetActive(true);
locked.SetActive(true);
        }


    }

    public void buy (){

        if(HEROCODENAME==1){

            if(HERO_1_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero1unlocked",1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_1_PRICE);

                UpdateCoin();


            }


        }
         if(HEROCODENAME==2){

            if(HERO_2_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero2unlocked",1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_2_PRICE);
                UpdateCoin();

            }


        }
         if(HEROCODENAME==3){

            if(HERO_3_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero3unlocked",1);
                                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_3_PRICE);
                UpdateCoin();


            }


        }

         if(HEROCODENAME==4){

            if(HERO_4_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero4unlocked",1);
                                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_4_PRICE);
                UpdateCoin();


            }


        }
         if(HEROCODENAME==5){

            if(HERO_5_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero5unlocked",1);
                                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_5_PRICE);
                UpdateCoin();


            }



        }
         if(HEROCODENAME==6){

            if(HERO_6_PRICE<=PlayerPrefs.GetInt("coinkayit")){

                PlayerPrefs.SetInt("hero6unlocked",1);
                                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") -HERO_6_PRICE);

                UpdateCoin();

            }


        }

        if (HEROCODENAME == 7)
        {

            if (HERO_7_PRICE <= PlayerPrefs.GetInt("coinkayit"))
            {

                PlayerPrefs.SetInt("hero7unlocked", 1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") - HERO_7_PRICE);
                UpdateCoin();


            }


        }
        if (HEROCODENAME == 8)
        {

            if (HERO_8_PRICE <= PlayerPrefs.GetInt("coinkayit"))
            {

                PlayerPrefs.SetInt("hero8unlocked", 1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") - HERO_8_PRICE);
                UpdateCoin();


            }


        }

        if (HEROCODENAME == 9)
        {

            if (HERO_9_PRICE <= PlayerPrefs.GetInt("coinkayit"))
            {

                PlayerPrefs.SetInt("hero9unlocked", 1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") - HERO_9_PRICE);
                UpdateCoin();


            }


        }

        if (HEROCODENAME == 10)
        {

            if (HERO_10_PRICE <= PlayerPrefs.GetInt("coinkayit"))
            {

                PlayerPrefs.SetInt("hero10unlocked", 1);
                PlayerPrefs.SetInt("coinkayit", PlayerPrefs.GetInt("coinkayit") - HERO_10_PRICE);

                UpdateCoin();

            }


        }

    }
    private void UpdateCoin()
    {
        coinstxt.text = PlayerPrefs.GetInt("coinkayit").ToString();
        menucointxt.text = PlayerPrefs.GetInt("coinkayit").ToString();

    }


    public void selectbuttonfor (){



        if(HEROCODENAME==1){

                            PlayerPrefs.SetInt("hero1selected",1);
                                                        PlayerPrefs.SetInt("hero2selected",0);
                                                        PlayerPrefs.SetInt("hero3selected",0);
                                                        PlayerPrefs.SetInt("hero4selected",0);
                                                        PlayerPrefs.SetInt("hero5selected",0);
                                                        PlayerPrefs.SetInt("hero6selected",0);
                                                        PlayerPrefs.SetInt("hero7selected", 0);
                                                        PlayerPrefs.SetInt("hero8selected", 0);
                                                        PlayerPrefs.SetInt("hero9selected", 0);
                                                        PlayerPrefs.SetInt("hero10selected", 0);



        }

        if (HEROCODENAME==2){

                                                        PlayerPrefs.SetInt("hero1selected",0);
                                                        PlayerPrefs.SetInt("hero2selected",1);
                                                        PlayerPrefs.SetInt("hero3selected",0);
                                                        PlayerPrefs.SetInt("hero4selected",0);
                                                        PlayerPrefs.SetInt("hero5selected",0);
                                                        PlayerPrefs.SetInt("hero6selected",0);
                                                        PlayerPrefs.SetInt("hero7selected", 0);
                                                        PlayerPrefs.SetInt("hero8selected", 0);
                                                        PlayerPrefs.SetInt("hero9selected", 0);
                                                        PlayerPrefs.SetInt("hero10selected", 0);


        }
         if(HEROCODENAME==3){

                             PlayerPrefs.SetInt("hero1selected",0);
                                                        PlayerPrefs.SetInt("hero2selected",0);
                                                        PlayerPrefs.SetInt("hero3selected",1);
                                                        PlayerPrefs.SetInt("hero4selected",0);
                                                        PlayerPrefs.SetInt("hero5selected",0);
                                                        PlayerPrefs.SetInt("hero6selected",0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);

        }
         if(HEROCODENAME==4){

  PlayerPrefs.SetInt("hero1selected",0);
                                                        PlayerPrefs.SetInt("hero2selected",0);
                                                        PlayerPrefs.SetInt("hero3selected",0);
                                                        PlayerPrefs.SetInt("hero4selected",1);
                                                        PlayerPrefs.SetInt("hero5selected",0);
                                                        PlayerPrefs.SetInt("hero6selected",0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);
        }
         if(HEROCODENAME==5){

  PlayerPrefs.SetInt("hero1selected",0);
                                                        PlayerPrefs.SetInt("hero2selected",0);
                                                        PlayerPrefs.SetInt("hero3selected",0);
                                                        PlayerPrefs.SetInt("hero4selected",0);
                                                        PlayerPrefs.SetInt("hero5selected",1);
                                                        PlayerPrefs.SetInt("hero6selected",0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);
        }
         if(HEROCODENAME==6){

  PlayerPrefs.SetInt("hero1selected",0);
                                                        PlayerPrefs.SetInt("hero2selected",0);
                                                        PlayerPrefs.SetInt("hero3selected",0);
                                                        PlayerPrefs.SetInt("hero4selected",0);
                                                        PlayerPrefs.SetInt("hero5selected",0);
                                                        PlayerPrefs.SetInt("hero6selected",1);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);
        }


        if (HEROCODENAME == 7)
        {

            PlayerPrefs.SetInt("hero1selected", 0);
            PlayerPrefs.SetInt("hero2selected", 0);
            PlayerPrefs.SetInt("hero3selected", 0);
            PlayerPrefs.SetInt("hero4selected", 0);
            PlayerPrefs.SetInt("hero5selected", 0);
            PlayerPrefs.SetInt("hero6selected", 0);
            PlayerPrefs.SetInt("hero7selected", 1);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);
        }
        if (HEROCODENAME == 8)
        {

            PlayerPrefs.SetInt("hero1selected", 0);
            PlayerPrefs.SetInt("hero2selected", 0);
            PlayerPrefs.SetInt("hero3selected", 0);
            PlayerPrefs.SetInt("hero4selected", 0);
            PlayerPrefs.SetInt("hero5selected", 0);
            PlayerPrefs.SetInt("hero6selected", 0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 1);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 0);
        }
        if (HEROCODENAME == 9)
        {

            PlayerPrefs.SetInt("hero1selected", 0);
            PlayerPrefs.SetInt("hero2selected", 0);
            PlayerPrefs.SetInt("hero3selected", 0);
            PlayerPrefs.SetInt("hero4selected", 0);
            PlayerPrefs.SetInt("hero5selected", 0);
            PlayerPrefs.SetInt("hero6selected", 0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 1);
            PlayerPrefs.SetInt("hero10selected", 0);
        }
        if (HEROCODENAME == 10)
        {

            PlayerPrefs.SetInt("hero1selected", 0);
            PlayerPrefs.SetInt("hero2selected", 0);
            PlayerPrefs.SetInt("hero3selected", 0);
            PlayerPrefs.SetInt("hero4selected", 0);
            PlayerPrefs.SetInt("hero5selected", 0);
            PlayerPrefs.SetInt("hero6selected", 0);
            PlayerPrefs.SetInt("hero7selected", 0);
            PlayerPrefs.SetInt("hero8selected", 0);
            PlayerPrefs.SetInt("hero9selected", 0);
            PlayerPrefs.SetInt("hero10selected", 1);
        }
    }
}
