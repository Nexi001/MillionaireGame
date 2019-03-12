using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

    void OnMouseDown()
    {
        gameflow.loadQuestion = "Y";
        gameflow.cleartext = "Y";
    }
} 
