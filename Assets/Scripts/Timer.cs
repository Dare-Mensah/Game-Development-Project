using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    public float currentTime;

    public float startingTime;

    public GameObject WinText;

    public GameObject Player;

    public GameObject PuzzleCam;

    public GameObject TimesUp;

    public GameObject CharacterTrigger;

    public GameObject thankYouText;

    public GameObject HiText;

    public GameObject PressEText;

    public GameObject Ball;

    public bool notRunning;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime >1 && PuzzleCam.activeInHierarchy == true && !notRunning)
        {
            currentTime -= 1 * Time.deltaTime;
        }
        //currentTime -= 1 * Time.deltaTime;
        //int minutes = Mathf.FloorToInt(currentTime / 60);
        //int seconds = Mathf.FloorToInt(currentTime % 60);
        //timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = currentTime.ToString("00:00");

        if(Input.GetKey(KeyCode.Escape))
        {
            currentTime = startingTime;
        }

        if(currentTime > 1 && WinText.activeInHierarchy == true)
        {
            Player.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            notRunning = true;
            StartCoroutine(WaitBeforeChange());
            thankYouText.SetActive(true);
            HiText.SetActive(false);
            PressEText.SetActive(false);
            CharacterTrigger.SetActive(false);

        }

        if (currentTime <=1 && WinText.activeInHierarchy == false)
        {
            TimesUp.SetActive(true);
            StartCoroutine(WaitBeforeChange());
            Player.SetActive(true);
            CharacterTrigger.SetActive(false);
            HiText.SetActive(false);
            PressEText.SetActive(false);
            
        }


    }



    IEnumerator WaitBeforeChange()
    {
        yield return new WaitForSeconds(3);

        PuzzleCam.SetActive(false);
    }

}
