using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
    }


}

