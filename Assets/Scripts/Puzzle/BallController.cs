using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float Speed;

    public float moveHorizontal;

    public float moveVertical;

    Rigidbody rB;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rB.AddForce(movement * Speed);

        //print(moveHorizontal);
        //print(moveVertical);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
