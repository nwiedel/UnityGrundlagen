using UnityEngine;

public class SimpleFirstPersonController : MonoBehaviour
{
    public float speed = 6.0f;
    public float mouseSensitivity = 100f;
    public float rotationSpeedMultiplier = 1f;

    private CharacterController characterController;
    private Transform cameraTransform;
    private float xRotation = 0f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Camera rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * rotationSpeedMultiplier * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * rotationSpeedMultiplier * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        // Player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(moveDirection * speed * Time.deltaTime);
    }
}