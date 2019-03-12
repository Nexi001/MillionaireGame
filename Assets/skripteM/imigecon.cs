using UnityEngine;
using System.Collections;

public class imigecon : MonoBehaviour {
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
 
    //public string image4;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        /*
        if (gameflow.loadQuestion == "Y")
        {
            
            if (gameflow.textPointer == 1)
            {
                GetComponent<SpriteRenderer>().sprite = image1;
                
            }
            if (gameflow.textPointer == 2)
            {
                GetComponent<SpriteRenderer>().sprite = image2;
              
            }
            if (gameflow.textPointer == 3)
            {
                GetComponent<SpriteRenderer>().sprite = image3;
            }
            if (gameflow.textPointer == 4)
            {
                GetComponent<SpriteRenderer>().sprite = image4;
            }
           
        }*/
    }

    void OnMouseDown(){
        gameflow.playerClicked = "Y";
        gameflow.currentSelection=gameObject.name; // gameobject je izbor 
        Debug.Log(gameObject.name);

   
	}
}
