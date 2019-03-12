using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pompub : MonoBehaviour
{
    public Transform polap;
    public static int okidac = 0;

    void Update()
    {
        if (okidac == 1)
        {
            polap.GetComponent<TextMesh>().text = "X";
        }
        else
        {
            polap.GetComponent<TextMesh>().text = "";
        }
    }
    void OnMouseDown()
    {

        polap.GetComponent<TextMesh>().text = "X";
        if(okidac == 0)
        {
            gameflow.pompub1  = 1;
            okidac = 1;
        }
    }
}