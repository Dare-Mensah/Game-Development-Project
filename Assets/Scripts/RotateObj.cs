using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float rotationSpeed;



    void Start()
    {
        
    }

    private void OnMouseDrag()
    {
        float XaxisRot = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRot = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, XaxisRot);
        transform.Rotate(Vector3.right, YaxisRot);
    }



    // Update is called once per frame
    void Update()
    {

    }
}
