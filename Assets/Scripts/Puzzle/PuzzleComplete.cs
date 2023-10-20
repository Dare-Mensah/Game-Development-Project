using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PuzzleComplete : MonoBehaviour
{
    public GameObject WinText;

    public GameObject Platform;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            WinText.SetActive(true);

            Platform.SetActive(true);

        }
    }
}
