using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCharacterTrigger : MonoBehaviour
{
    public GameObject StartText1;

    public GameObject MidText2;

    public GameObject PressEText3;

    public GameObject YesText;

    public GameObject NoText;

    public GameObject PuzzleObj;

    public GameObject PlayerCam1;

    public GameObject PlayerCam2;

    public bool Enter;


    // Start is called before the first frame update
    void Start()
    {
        Enter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enter == true && Input.GetKeyDown(KeyCode.E))
        {
            PressEText3.SetActive(false);
            StartText1.SetActive(false);
            MidText2.SetActive(true);

            YesText.SetActive(true);
            NoText.SetActive(true);

        }

        if (Enter == true && Input.GetKeyDown(KeyCode.F))
        {
            YesText.SetActive(false);
            NoText.SetActive(false);
            MidText2.SetActive(false);
            PuzzleObj.SetActive(true);


        }

        if(Enter == true && Input.GetKeyDown(KeyCode.G))
        {
            StartText1.SetActive(true);
            MidText2.SetActive(false);
            YesText.SetActive(false);
            NoText.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if(other.gameObject.tag == "Player")
        {
            Enter = true;
            PressEText3.SetActive(true);
            StartText1.SetActive(true);

        }
    }
}
