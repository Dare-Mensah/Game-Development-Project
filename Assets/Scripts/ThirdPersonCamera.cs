using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    [Header("Refernces")]
    //Refernces to the in game transform objects.
    public Transform Orientation;
    public Transform Player;
    public Transform PlayerObject;
    public Rigidbody rB;

    public float rotatioSpeed;

    public Transform focusLookAt;

    public GameObject BasicCam;
    public GameObject FocusCam;
    public GameObject PuzzleCam;

    public CamraPosition currentstyle;

    public enum CamraPosition
    {
        Basic, 
        Focus,
        Puzzle,
    }


    // Start is called before the first frame update
    void Start()
    {
        // making the cursor invisible and locked to center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchCamPos(CamraPosition.Basic);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchCamPos(CamraPosition.Focus);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SwitchCamPos(CamraPosition.Puzzle);



        //finding out the rotation oritnation
        Vector3 viewDirection = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        Orientation.forward = viewDirection.normalized;

        //Rotating the player object
        if(currentstyle == CamraPosition.Basic || currentstyle == CamraPosition.Puzzle) // normal basic camera angle
        {
            float horizontalInput = Input.GetAxis("Horizontal"); //horizontal input
            float verticalInput = Input.GetAxis("Vertical"); //vertical input
            Vector3 inputDirection = Orientation.forward * verticalInput + Orientation.right * horizontalInput;

            if (inputDirection != Vector3.zero)
                PlayerObject.forward = Vector3.Slerp(PlayerObject.forward, inputDirection.normalized, Time.deltaTime * rotatioSpeed);
        }
        
        else if(currentstyle == CamraPosition.Focus)
        {
            Vector3 dirToFocusLookAt = focusLookAt.position - new Vector3(transform.position.x, focusLookAt.position.y, transform.position.z);
            Orientation.forward = dirToFocusLookAt.normalized; // focusing camera on the focus empty game object to provide a new camera angle 

            PlayerObject.forward = dirToFocusLookAt.normalized;
        }
    }

    private void SwitchCamPos(CamraPosition newPosition)
    {
        BasicCam.SetActive(true);
        FocusCam.SetActive(false);
        PuzzleCam.SetActive(false);

        if (newPosition == CamraPosition.Basic) BasicCam.SetActive(true);
        if (newPosition == CamraPosition.Focus) FocusCam.SetActive(true);
        if (newPosition == CamraPosition.Puzzle) PuzzleCam.SetActive(true);

        currentstyle = newPosition;

    }
}
