using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izlaz : MonoBehaviour {
    public void Update()
    {

        if (exit2.potvrda == 1)
        {
            exitgame();
            exit2.potvrda = 0;
        }
    }
public void exitgame()
    {
        Debug.Log("Pokrenut exit");
        Application.Quit();
    }

}

