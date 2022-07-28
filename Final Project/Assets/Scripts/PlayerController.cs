using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private CharacterController playerController;

    public float MouseSensitivity;
    public float movementSpeed;
    public AudioSource playerFootsteps;
    private float gravity = -9.81f;

    private Vector3 Velocity;
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;
    private float CamXRotation;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Movement();
        Look();

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)))
        {
            playerFootsteps.enabled = true;
        }
        else
        {
            playerFootsteps.enabled = false;
        }
  
    }

    void Movement()
    {
        Vector3 MoveVector = transform.forward * playerMovementInput.z + transform.right * playerMovementInput.x;

        if (playerController.isGrounded)
        {
            Velocity.y = -3f;
        }
        else
        {
            Velocity.y -= gravity * -2f * Time.deltaTime;
        }

        playerController.Move(MoveVector * movementSpeed * Time.deltaTime);
        playerController.Move(Velocity * Time.deltaTime);
        
        
    }

    void Look()
    {
        CamXRotation -= playerMouseInput.y * MouseSensitivity;

        transform.Rotate(0f, playerMouseInput.x * MouseSensitivity, 0f);
        PlayerCamera.localRotation = Quaternion.Euler(CamXRotation, 0f, 0f);
    }
}
