using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kocka : MonoBehaviour
{
    //    Vector2- 2 vrednosti x i y
    //Vector3- 3 vrednosti(x, y, z)

    //1.zadatak video 14
    public GameObject kvadrat;
    /*private Vector2 pos;
     private Vector3 pos2;zadatak 1*/

  /*  void Start()
    {
        pos = kvadrat.transform.position;
        pos = new Vector2(0f, 0f);
        Debug.Log(pos.x); 
        Debug.Log(pos.y);
    */

    //2.zadatak video 15/*
    /*
    void Start() //cisto informativni zadatak ne radi ali da znas kao pseudo kod
    {
        Vector3 pos = transform.position;// ovo je za 
    Vector3 rot = transform.rotation;//transform je onaj meni kad kliknes u inspektoru i ovako se  pristupa
    Vector3 scale = transform.localScale;

    }*/
    //3.zadatak video 16
    private Vector3 tempPos;
    void Update()
    {
        // znaci ako zelimo da pomeramo objekat moramo  da radimo sa promenljivom nema drugog nacina
        tempPos = kvadrat.transform.position;// original  pozicija
        if (tempPos.x < -2f)//znaci dolazi do pozicije - 2f, -2f je priblizno 2 to je mozda 1.3 x ja msm
        {
            tempPos.x += 1f * Time.deltaTime; //ovo je brzina 1f imas u skripti sta je ovo deltatime , znaci za svaku poziciju radis ovako
        }
        else if(gameflow.brpitanim == 2)
        {
            tempPos.x += 3f * Time.deltaTime;
        }
            kvadrat.transform.position = tempPos; // i  nova poziciji znaci u translaciji ide drugacije

        }

  /*  public float speed = 5f;// ako idemo ka gorr sporije ce ici kocka ka dole brze ali nisamsiguran proveri ovo

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0)// znaci ide uz y - osu  polako, ako zelimo da ide glatko koristimo ovo deltaTime, imas objasnjenje za deltatime u notpedau zvanom seckadeltatime ako dodas -ide - ipsilon ako ne dodas nista ide + ipsilon
    //transform.Translate(0,-speed * Time.deltaTime, 0) 

    }
*/

    //// Use this for initialization
    //void Start () {

    //	}

    //	// Update is called once per frame
    //	void Update () {

    //	}
}
