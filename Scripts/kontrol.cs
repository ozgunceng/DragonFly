using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class kontrol : MonoBehaviour{

    
    public Sprite[] KusSprite;
    
    SpriteRenderer spriteRenderer;
    bool ileriGeriKontrol = true;
    int kusSayac = 0;
    float kusAnimasyonZaman = 0;
    Rigidbody2D fizik;
    int puan = 0;
    public Text puanText;
    bool oyunbitti = true;
    OyunKontrol oyunKontrol;
    AudioSource []sesler;
    int enYuksekPuan = 0;

    int coin = 0;



   


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        fizik = GetComponent<Rigidbody2D>();
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol").GetComponent<OyunKontrol>();
        sesler = GetComponents<AudioSource>();
        enYuksekPuan = PlayerPrefs.GetInt("kayit");

        coin= PlayerPrefs.GetInt("coinkayit");

        Debug.Log("en yuksek puan  = "+enYuksekPuan);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0)&& oyunbitti)
        {
          
            fizik.velocity = new Vector2(0, 0);// hizi sıfır yaptık
            fizik.AddForce(new Vector2(0,200));//ondan sonra kuvvet
            sesler[0].Play();
           
        }
        if (fizik.velocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 30);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -30);

        }
        Animasyon();
    }
    void Animasyon()
    {
        kusAnimasyonZaman += Time.deltaTime;
        if (kusAnimasyonZaman > 0.1f)
        {
            kusAnimasyonZaman = 0;



            if (ileriGeriKontrol)
            {
                spriteRenderer.sprite = KusSprite[kusSayac];
                kusSayac++;//0,1,2,3
                if (kusSayac == KusSprite.Length)
                {
                    ileriGeriKontrol = false;
                }
            }
            else
            {
                kusSayac--;
                spriteRenderer.sprite = KusSprite[kusSayac];
                if (kusSayac == 0)
                {
                    ileriGeriKontrol = true;
                }
            }
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "puan")
        {
            puan++;
            puanText.text = "" + puan;
            sesler[1].Play();
            PlayerPrefs.SetInt("puanKayit", puan);



            //Debug.Log(puan);

        }
        if (col.gameObject.tag == "engel")
        {
            oyunbitti = false;
            sesler[2].Play();
            oyunKontrol.oyunbitti();
            GetComponent < CircleCollider2D >().enabled=false;

            coin = coin + puan;
            PlayerPrefs.SetInt("coinkayit", coin);


            if (puan> enYuksekPuan)
            {
                enYuksekPuan = puan;
                PlayerPrefs.SetInt("kayit", enYuksekPuan);

            }
            Invoke("anaMenuyeDon", 1);


        }
        

    }
    void anaMenuyeDon()
    {
        SceneManager.LoadScene("menu");

    }

}
