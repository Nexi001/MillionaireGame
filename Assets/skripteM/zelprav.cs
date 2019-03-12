using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zelprav : MonoBehaviour
{
        public GameObject kvadrat;
       private Vector3 tempPos;
    private double pomeraj = 0.543;
    void Start()
    {
      kvadrat.GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, 0f);

    }
    void Update()
    {
        tempPos = kvadrat.transform.position;// original  pozicija
         if(gameflow.brpitanim == 1)
        {
            tempPos.y = -1.48f;
        }
        else if (tempPos.y <= -0.943f && gameflow.brpitanim == 2)//znaci dolazi do pozicije - 2f, -2f je priblizno 2 to je mozda 1.3 x ja msm
        {
            tempPos.y += 1f * Time.deltaTime; //ovo je brzina 1f imas u skripti sta je ovo deltatime , znaci za svaku poziciju radis ovako
        }
        else if (tempPos.y <= -0.4f && gameflow.brpitanim == 3)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y <= 0.13f && gameflow.brpitanim == 4)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y <= 0.13f + pomeraj && gameflow.brpitanim == 5)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y <= (0.13f + pomeraj * 2) && gameflow.brpitanim == 6)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 3) && gameflow.brpitanim == 7)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 4) && gameflow.brpitanim == 8)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 5) && gameflow.brpitanim == 9)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 6) && gameflow.brpitanim == 10)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 7) && gameflow.brpitanim == 11)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f+ pomeraj  * 8) && gameflow.brpitanim == 12)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj * 9) && gameflow.brpitanim == 13)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 10) && gameflow.brpitanim == 14)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
        else if (tempPos.y < (0.13f + pomeraj  * 11) && gameflow.brpitanim == 15)
        {
            tempPos.y += 1f * Time.deltaTime;
        }
    kvadrat.transform.position = tempPos; // i  nova poziciji znaci u translaciji ide drugacije

    }
}
