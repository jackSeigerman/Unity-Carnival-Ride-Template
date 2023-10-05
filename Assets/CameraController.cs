using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private float rotationSpeed = 5f;
    private float pitchLimit = 80f;
    private bool isRotationMode = false;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        originalPosition = cameraTransform.position;
        originalRotation = cameraTransform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Toggle between rotation mode and default mode
            isRotationMode = !isRotationMode;
            if (isRotationMode)
            {
                // Enter rotation mode
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                // Exit rotation mode
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                RestoreOriginalPositionAndRotation();
            }
        }

        if (isRotationMode)
        {
            // Rotate the camera using arrow keys
            float pitch = cameraTransform.rotation.eulerAngles.x;
            float yaw = cameraTransform.rotation.eulerAngles.y;

            pitch -= Input.GetAxis("Vertical") * rotationSpeed;
            pitch = Mathf.Clamp(pitch, -pitchLimit, pitchLimit);
            yaw += Input.GetAxis("Horizontal") * rotationSpeed;

            cameraTransform.rotation = Quaternion.Euler(pitch, yaw, 0f);
        }
    }

    void RestoreOriginalPositionAndRotation()
    {
        cameraTransform.position = originalPosition;
        cameraTransform.rotation = originalRotation;
    }
}
