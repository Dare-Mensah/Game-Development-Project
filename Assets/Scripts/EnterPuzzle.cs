using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPuzzle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;

    public GameObject PlayerCam;

    public GameObject PuzzleCamera;

    public GameObject HiText;


    void Start()
    {
        PuzzleCamera.SetActive(false);
    }


    //private void OnTriggerEnter(Collider other)
   // {
        //if (other.gameObject.tag == "Player")
        //{
            //PlayerCam.SetActive(false);
            //PuzzleCamera.SetActive(true);
            //Player.SetActive(false);
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;

        //}


    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PlayerCam.SetActive(true);
            PuzzleCamera.SetActive(false);
            Player.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            HiText.SetActive(true);
        }
    }
}
