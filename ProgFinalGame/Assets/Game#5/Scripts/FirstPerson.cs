using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FirstPerson : MonoBehaviour
{
    public AudioSource defFootsteps;
    public AudioSource footsteps;
    public AudioSource running;
    public AudioSource GarWalk;

    public Camera playerCamera;
    public float walkSpeed = 6.5f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;


    public float lookSpeed = 2f;
    public float lookXLimit = 45f;


    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    public bool canMove = true;
    public bool isRunning = false;


    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        footsteps = defFootsteps;
    }

    void Update()
    {
        #region Handles Movment
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        // Press Left Shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        #endregion

        #region Handles Jumping
        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        #endregion

        #region Handles Rotation
        characterController.Move(moveDirection * Time.deltaTime);

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }

        if (Input.GetKey(KeyCode.W) && isRunning == true || Input.GetKey(KeyCode.A) && isRunning == true || Input.GetKey(KeyCode.S) && isRunning == true || Input.GetKey(KeyCode.D) && isRunning == true)
        {
            footsteps.enabled = false;
            running.enabled = true;
        }
        else
        {
            running.enabled = false;
        }

        #endregion
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GarbWalk"))
        {
            footsteps = GarWalk;
            defFootsteps.enabled = false;
            
            Debug.Log("Walking On Garbage");
        }

        if (other.CompareTag("Hallway"))
        {
            runSpeed = 1.65f;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GarbWalk"))
        {
            footsteps = defFootsteps;
            GarWalk.enabled = false;

            Debug.Log("Walking On Garbage");

        }

        if (other.CompareTag("Hallway"))
        {
            runSpeed = 5f;
            
        }
    }



}
