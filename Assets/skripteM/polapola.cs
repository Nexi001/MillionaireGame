using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polapola : MonoBehaviour
{
    public Transform polap;
    public static int polapola1 = 0;
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
        if(okidac == 0)
        {
            polapola1 = 1;
            okidac = 1;
        }
           
        
        polap.GetComponent<TextMesh>().text = "X";
        
    }
}