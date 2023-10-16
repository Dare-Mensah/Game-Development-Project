using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float rotationSpeed;



    void Start()
    {
        
    }

    //private void OnMouseDrag()
    //{
        //float XaxisRot = Input.GetAxis("Mouse X") * rotationSpeed;
        //float YaxisRot = Input.GetAxis("Mouse Y") * rotationSpeed;

        //transform.Rotate(Vector3.down, XaxisRot);
        //transform.Rotate(Vector3.right, YaxisRot);
    //}



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
