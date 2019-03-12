using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;// za restart dugme
public class gameflow : MonoBehaviour
{
    public Transform timerText;
    private float startTime;
    public Transform informacije;
    public Transform txtkvdrt;
    public Transform aTextObj;
    public Transform bTextObj;
    public Transform cTextObj;
    public Transform dTextObj;
    public Transform eTextObj;
    public Transform sysTextObj;
    List<string> questions = new List<string>() { "", "", "", "Koliko je 2+3", "Koji je glavni grad Srbije", "Koliko je 5-5", "Ako imate 40 godina pre 20 ste imali", "Koji je danas dan", "Koji je danas datum", "Koliko je 5*4", "Koje je izmislio naizmenicnu struju", "U kom jeziku je ova igrica kreirana", "Da li su pre 20 godina postojali mobilni?", "Popularni sistem pre 10 godina je bio?", "Ova igrica je napravljena za koji predmet?", "Ako je danas utorak, sta je sutra?", "Mozemo li upravljati racunarom bez monitora", "Da li ste punoletni", "Da li ste punoletni" };
    List<string> correctSelection = new List<string>() {"","","", "izbor2", "izbor1", "izbor2", "izbor3", "izbor2", "izbor4", "izbor2", "izbor4", "izbor3", "izbor2", "izbor3", "izbor1", "izbor2", "izbor1", "izbor2", "izbor3", "izbor2", "izbor4", "izbor2", "izbor3", "izbor4", "izbor3", "izbor1", "izbor4", "izbor3", "izbor1" };
    public string[] odgovori;
    public static string currentSelection;
    public static int textPointer;
    public static int i = 2;
    public int m = 0;
    public static int reset = 0;
    public static int brpitanim = 1;
    public static int a = 0;
    public int brpit = 0;
    public static int pomp1 = 0;
    public static int test = 0;
    public static int pompub1 = 0;
    public static string tacodg; 
    public static string playerClicked = "N";
    public static string loadQuestion = "Y";
    public static string cleartext = "N";
    private float brsek = 0;
    private int blok8 = 0;
    private int pobednik = 0;
    public static int vremeist = 0;
    public GameObject kvadrat;
    public Vector3 kvadpriv;
    private int upozorenje = 0;
    private int napred = 0;
    //Use this for initialization
    void Start()

    {
        //startTime = Time.time;//1 zadatak nastavak dole

        odgovori = new string[30];

        if (brpit == 1)
        {
            odgovori[i] = "5";
            odgovori[i + 1] = "8";
            odgovori[i + 2] = "0";
            odgovori[i + 3] = "13";
        }
        kvadpriv.y = 2.25f;
        kvadpriv.x = -0.61f;
        kvadpriv.z = -2f;
        kvadrat.transform.position = kvadpriv;
        txtkvdrt.GetComponent<TextMesh>().text = "Da li zelite da postanete milioner?";
       
    }

    // Update is called once per frame
    void Update()
    {




        if (brpit == 1)
        {
            odgovori[i] = "5";
            odgovori[i + 1] = "8";
            odgovori[i + 2] = "0";
            odgovori[i + 3] = "13";
        }
          else  if (brpit == 2)
        {
            odgovori[i] = "Beograd ";
            odgovori[i+1] = "Novi Sad";
            odgovori[i+2] = "Valjevo";
            odgovori[i + 3] = "Subotica";
        }
        else if (brpit == 3)
        {
            odgovori[i] = "0";
            odgovori[i + 1] = "5";
            odgovori[i + 2] = "2";
            odgovori[i + 3] = "3";
        }
        else if (brpit == 4)
        {
            odgovori[i] = "20";
            odgovori[i + 1] = "10";
            odgovori[i + 2] = "4";
            odgovori[i + 3] = "3";
        }
        else if (brpit == 5)
        {
            odgovori[i] = "utorak";
            odgovori[i + 1] = "petak ";
            odgovori[i + 2] = "subota";
            odgovori[i + 3] = "nedelja";
        }
        else if (brpit == 6)
        {
            odgovori[i] = "23";
            odgovori[i + 1] = "15";
            odgovori[i + 2] = "3";
            odgovori[i + 3] = "2";
        }
        else if (brpit == 7)
        {
            odgovori[i] = "20";
            odgovori[i + 1] = "1";
            odgovori[i + 2] = "3";
            odgovori[i + 3] = "5";
        }
        else if (brpit == 8)
        {
            odgovori[i] = "Nikola Tesla";
            odgovori[i + 1] = "Tomas Edison";
            odgovori[i + 2] = "Albert Anstajn";
            odgovori[i + 3] = "Niko";
        }
        else if (brpit == 9)
        {
            odgovori[i] = "C#";
            odgovori[i + 1] = "Java";
            odgovori[i + 2] = "Java script";
            odgovori[i + 3] = "C";
        }
        else if (brpit == 10)
        {
            odgovori[i] = "ne";
            odgovori[i + 1] = "da ";
            odgovori[i + 2] = "mozda";
            odgovori[i + 3] = "verovatno";
        }
        else if (brpit == 11)
        {
            odgovori[i] = "Windows Xp";
            odgovori[i + 1] = "Windows 7";
            odgovori[i + 2] = "Windows 10";
            odgovori[i + 3] = "Windows 8";
        }
        else if (brpit == 12)
        {
            odgovori[i] = "DM2";
            odgovori[i + 1] = "DM";
            odgovori[i + 2] = "OP2";
            odgovori[i + 3] = "OS1";
        }
        else if (brpit == 13)
        {
            odgovori[i] = "sreda";
            odgovori[i + 1] = "cetvrtak";
            odgovori[i + 2] = "subota ";
            odgovori[i + 3] = "nedelja";
        }
        else if (brpit == 14)
        {
            odgovori[i] = "ne";
            odgovori[i + 1] = "da";
            odgovori[i + 2] = "mozda";
            odgovori[i + 3] = "ponekad";
        }
        else if (brpit == 15)
        {
            odgovori[i] = "Da";
            odgovori[i + 1] = "Ne";
            odgovori[i + 2] = "Bio sam pre 18";
            odgovori[i + 3] = "Mozda";
        }
        else if (brpit == 16)
        {
            odgovori[i] = "Da";
            odgovori[i + 1] = "Ne";
            odgovori[i + 2] = "Bio sam pre 18";
            odgovori[i + 3] = "Mozda";
        }
      
        if (dapoc.da == 1)
        {
            kvadpriv.z = 5f;
            kvadrat.transform.position = kvadpriv;
            txtkvdrt.GetComponent<TextMesh>().text = "Da li zelite da postanete milioner?";
            dapoc.da = 0;
            reset = 0;
            brsek = 0;
            pobednik = 0;
            i = 3;
        }
        if (reset == 1)
        {
            brsek = 0;
            kvadpriv.y = 2.25f;
            kvadpriv.x = -0.61f;
            kvadpriv.z = -1f;
            kvadrat.transform.position = kvadpriv;
            polapola.okidac = 0;
            pompub.okidac = 0;
            pomp.okidac = 0;
            if (pobednik == 1)
            {
                txtkvdrt.GetComponent<TextMesh>().text = "Postali ste milioner,da li zelite opet igrati se?";
            }
            else {

                txtkvdrt.GetComponent<TextMesh>().text = "Da li zelite da postanete milioner?";
            }
            reset = 0;
            
            upozorenje = 1;
        }


        //kvadpriv.z = 5f;
        //kvadrat.transform.position = kvadpriv;


        if (correctSelection[textPointer] == "izbor1")
        {
            tacodg = "A";
        }
        else if (correctSelection[textPointer] == "izbor2")
        {
            tacodg = "B";
        }
        else if (correctSelection[textPointer] == "izbor3")
        {
            tacodg = "C";
        }
        else if (correctSelection[textPointer] == "izbor4")
        {
            tacodg = "D";
        }
        if (pompub1 == 1)
        {
            informacije.GetComponent<TextMesh>().text = "Publika: " + tacodg;
        }
        else if (pomp1 == 1)
        {
            informacije.GetComponent<TextMesh>().text = "Marinko: " + tacodg;

        }
        else
        {
            informacije.GetComponent<TextMesh>().text = "";
        }

        if (polapola.polapola1 == 1)
        {
            if (correctSelection[textPointer] == "izbor1")
            {
                cTextObj.GetComponent<TextMesh>().text = "";
                dTextObj.GetComponent<TextMesh>().text = "";
            }
            else if (correctSelection[textPointer] == "izbor2")
            {
                bTextObj.GetComponent<TextMesh>().text = "";
                eTextObj.GetComponent<TextMesh>().text = "";
            }
            else if (correctSelection[textPointer] == "izbor3")
            {
                bTextObj.GetComponent<TextMesh>().text = "";
                eTextObj.GetComponent<TextMesh>().text = "";
            }
            else if (correctSelection[textPointer] == "izbor4")
            {
                bTextObj.GetComponent<TextMesh>().text = "";
                cTextObj.GetComponent<TextMesh>().text = "";
            }

        }




        if (brsek > 15)
        {
            //loadQuestion = "Y";
            //brpitanim += 1;
           
            reset = 1;
        }
        if (vremeist == 1)
        {
            brsek = 15;// ako zelis da  vreme ide unazad samo stavis ovde 
        }
        else
        {
            brsek += Time.deltaTime;// ako zelis da  vreme ide unazad samo stavis ovde 
        }


        /*
        1 zadatak nastavak gore
        float t = Time.time - startTime; //1 zadatak sa tajmerom nastavak, ovo je isto neki primer sa tajmerom samo sto ovde nema velike kontrole kao sto je restart tako glupo zar ne 
        string minutes = ((int)t / 60).ToString(); //  isto do 60 minuta
        string secounds = (t % 60).ToString("f0");//znaci broji do 60 sekundi i onda ga vrati na 0
        int.TryParse(secounds, out a); // konverzija iz stringa u int
        timerText.GetComponent<TextMesh>().text = secounds;
        */
        timerText.GetComponent<TextMesh>().text = brsek.ToString("f0");//ovo f je koliko zelis u zarezu cifara da stavis
        if (brsek > 9.5)
        {
            timerText.GetComponent<TextMesh>().color = Color.red;
        }
        else
        {

            timerText.GetComponent<TextMesh>().color = Color.white;
        }

        if (i >= 18)
        {
            brpit = 15;
        }
        else {
            brpit = i - 2;
        }
        
       
        if (loadQuestion == "Y")
        {
            //textPointer = Random.Range(1, 5);
            /*  if(i == 8 && blok8 == 0) //nesto nije htelo da radi na 8 pitanju pola pola pa sam stavio ovo
              {
                  i = 9;
                  blok8 = 1;
              }*/
            textPointer = i;

            aTextObj.GetComponent<TextMesh>().text = brpit + ". " + questions[textPointer];
            if (correctSelection[textPointer] == "izbor1")
            {

                bTextObj.GetComponent<TextMesh>().text = odgovori[textPointer];
                cTextObj.GetComponent<TextMesh>().text = odgovori[i + 1];
                dTextObj.GetComponent<TextMesh>().text = odgovori[i + 2];
                eTextObj.GetComponent<TextMesh>().text = odgovori[i + 3];
                informacije.GetComponent<TextMesh>().text = "";
            }
            else if (correctSelection[textPointer] == "izbor2")
            {
                cTextObj.GetComponent<TextMesh>().text = odgovori[textPointer];
                dTextObj.GetComponent<TextMesh>().text = odgovori[i + 3];
                bTextObj.GetComponent<TextMesh>().text = odgovori[i + 2];
                eTextObj.GetComponent<TextMesh>().text = odgovori[i + 1];
                informacije.GetComponent<TextMesh>().text = "";
            }
            else if (correctSelection[textPointer] == "izbor3")
            {
                dTextObj.GetComponent<TextMesh>().text = odgovori[textPointer];
                bTextObj.GetComponent<TextMesh>().text = odgovori[i + 1];
                cTextObj.GetComponent<TextMesh>().text = odgovori[i + 3];
                eTextObj.GetComponent<TextMesh>().text = odgovori[i + 2];
            }
            else if (correctSelection[textPointer] == "izbor4")
            {
                eTextObj.GetComponent<TextMesh>().text = odgovori[textPointer];
                bTextObj.GetComponent<TextMesh>().text = odgovori[i + 1];
                cTextObj.GetComponent<TextMesh>().text = odgovori[i + 3];
                dTextObj.GetComponent<TextMesh>().text = odgovori[i + 2];
            }
            if (i == 18)
            {
                reset = 1;
                pobednik = 1;
            }
            else
            {
                i++;
               
            }

            pomp1 = 0;
            pompub1 = 0;
            polapola.polapola1 = 0;

            //aTextObj.GetComponent<TextMesh>().text = questions[textPointer];

        }

       
        if (playerClicked == "Y")
        {
            if (currentSelection == correctSelection[textPointer])
            {
                if (i == 3)
                {
                    napred += 1;
                }
                //  Debug.Log("Correct");
                playerClicked = "N";
                //sysTextObj.GetComponent<TextMesh> ().text = "Correct!";
                m = 1;
                test = 0;
                blok8 = 0;   
            }
            else if (currentSelection != correctSelection[textPointer])
            {
                if(blok8 == 0)
                {
                    reset = 1;
                    blok8 = 1;
                }
               
            }
               
            
           
        }
        brpitanim = i-3;
       
    }  
    void LateUpdate()
    {
       
        if (i == 3) { loadQuestion = "Y"; 
        } 
        else
        {
            loadQuestion = "N"; }
        if (upozorenje == 1)
        {
            loadQuestion = "Y";
            upozorenje = 0;
        }

        if (m==1){//ovo ide posle updejta  za menjanje sledeceg pitanja
            if (vremeist == 1)
            {
            }
            else
            {
                
                loadQuestion = "Y";
                if (napred == 1)
                {
                    loadQuestion = "Y";
                }
                brsek = 0;
                
                if (upozorenje == 1 && i!=3)
                {
                    i = 3;
                    upozorenje = 0;
                }
             

                m = 0;
                
            }
        }
   /* if (cleartext == "Y")
    {
        sysTextObj.GetComponent<TextMesh>().text = "";
        cleartext = "N";
    }
    else if (currentSelection != correctSelection[textPointer])
    {
        sysTextObj.GetComponent<TextMesh>().text = "";
        cleartext = "Y";
    }
    */
   
    }
}
