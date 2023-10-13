using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{

    public GameObject Player;

    public GameObject PlayerCam;

    public GameObject PuzzleCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerCam.SetActive(true);
            PuzzleCam.SetActive(false);
            Player.SetActive(true);

        }
    }
}
