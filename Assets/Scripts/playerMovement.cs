using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody controller;
    public float movementSpeed = 5f;
    public Transform flashlight;
    public GameObject[] flashlightPositions;
    private float horizontal;
    private float vertical;

    Vector3 direction;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0f, vertical).normalized;

        Vector3 inputedDirection = flashlight.position;
        Quaternion inputedRotation = flashlight.transform.rotation;

        if (Input.GetKeyDown(KeyCode.A))
        {
            inputedDirection = Vector3.Slerp(flashlight.position, flashlightPositions[2].transform.position, movementSpeed);
            inputedRotation = Quaternion.Slerp(flashlight.rotation, flashlightPositions[2].transform.rotation, movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputedDirection = Vector3.Slerp(flashlight.position, flashlightPositions[3].transform.position, movementSpeed);
            inputedRotation = Quaternion.Slerp(flashlight.rotation, flashlightPositions[3].transform.rotation, movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputedDirection = Vector3.Slerp(flashlight.position, flashlightPositions[1].transform.position, movementSpeed);
            inputedRotation = Quaternion.Slerp(flashlight.rotation, flashlightPositions[1].transform.rotation, movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputedDirection = Vector3.Slerp(flashlight.position, flashlightPositions[0].transform.position, movementSpeed);
            inputedRotation = Quaternion.Slerp(flashlight.rotation, flashlightPositions[0].transform.rotation, movementSpeed);
        }

        flashlight.position = inputedDirection;
        flashlight.transform.rotation = inputedRotation;


    }

    void FixedUpdate()
    {
        controller.velocity = direction * movementSpeed;
    }
}
