using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=k9FvVwd5pR4 tutorijal
//https://www.youtube.com/watch?v=phX-1vq5YPw tutorijal2
public class Lerp : MonoBehaviour {

    public GameObject wall;// je onaj pravugaonik
    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 zadnjpoz; 
    private int blokada = 0;//da blokiramo jer ako nije ode u bestraga na nebo jer non stop ce da mnozi u updejtu ako stavis blokadu nece
    private bool blokada2 = false;
    private float distance = 0.55f;// rastojanje koliko da ide
    private float lerpTime = 3;
    private float currentLerpTime = 1;//sa ovi m definisemo brzinu 
    private bool KeyHit = false;

    void Start()
    {
        startPos = wall.transform.position;
        //endPos = wall.transform.position + Vector3.up * distance;
        endPos = wall.transform.position;

    }

    void Update()
    {
        if (gameflow.brpitanim == 8 || gameflow.brpitanim == 12)//ovo je postavljeno jer ne stoji bas precizno kocka na brojevima pa mora malo se srediti da bude pravo
        {
            distance = 0.50f;
        }
        else
        {
            distance = 0.55f;
        }
        switch (gameflow.brpitanim)
        {
            case 2:
                if (blokada == 0)//objasnjeno je gore na vrhu sta je ovo gde je definisana promenljiva
                {
                    endPos = wall.transform.position + Vector3.up * distance;// i samo ga dodajes za toliko na svakom pitanju :)                  
                    blokada = 1;// umest                o ovoga si mogao staviti blokada++ ali nema veze i ovako radi
                    
                }
                break;
                case 3:
                if (blokada == 1)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 2;
                    
                }
                break;
                case 4:
                if (blokada == 2)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 3;
                   
                }
                break;
                case 5:
                if (blokada == 3)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 4;
                }
                break;
                case 6:
                if (blokada == 4)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 5;
                }
                break;
                case 7:
                if (blokada == 5)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 6;
                }
                break;
                case 8:
                if (blokada == 6)
                {

                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 7;
                }
                break;
                case 9:
                if (blokada == 7)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 8;
                }
                break;
                case 10:
                if (blokada == 8)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 9;
                }
                break;
                case 11:
                if (blokada == 9)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 10;
                }
                break;
                case 12:
                if (blokada == 10)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 11;
                }
                break;
                case 13:
                if (blokada == 11)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 12;
                }
                break;
                case 14:
                if (blokada == 12)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 13;
                }
                break;
                case 15:
                if (blokada == 13)
                {
                    endPos = wall.transform.position + Vector3.up * distance;
                    blokada = 14;
                }
                break;
                default:
                // ovde stavi poslednji uslov i obavezno ubaci blokadu
       
                break;
        }
        /*   if (Input.GetKeyDown(KeyCode.A))
           {
               KeyHit = true; // ovo je samo unos preko tastature da eto znas
           }*/
        KeyHit = true;// za ovo gore u kom eto da vidis cist primer inace moze i bez ovoga keyhit
        if (KeyHit == true)
        {
                currentLerpTime += Time.deltaTime;

                if (currentLerpTime >= lerpTime)
                {
                    currentLerpTime = lerpTime;   //ja mislim da je ovo zato sto brzina raste pa mu ovo kaze da se smanji to jest kad dostigne brzinu da krene iz pocetka
                }
                float Perc = currentLerpTime / lerpTime;
            
            
            transform.position = Vector3.Lerp(startPos, endPos, Perc);
       
        }
    }
}
