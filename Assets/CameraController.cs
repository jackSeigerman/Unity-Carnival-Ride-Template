using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The target object to follow (your ride)
    public float moveSpeed = 5f; // Speed at which the camera moves
    public float rotationSpeed = 2f; // Speed at which the camera rotates
    public float maxYaw = 360f; // Maximum yaw rotation (unconstrained)
    public float minPitch = -80f; // Minimum pitch angle
    public float maxPitch = 80f; // Maximum pitch angle
    public Vector2 minBounds = new Vector2(-10f, -10f); // Minimum XZ bounds
    public Vector2 maxBounds = new Vector2(10f, 10f); // Maximum XZ bounds

    private float currentPitch = 0f;

    private void Update()
    {
        // Check for input to control camera movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Calculate new position based on input
        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Clamp camera position within the defined bounds
        newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
        newPosition.z = Mathf.Clamp(newPosition.z, minBounds.y, maxBounds.y);

        // Set the camera's new position
        transform.position = newPosition;

        // Check for input to control camera rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate new pitch and yaw angles based on input
        currentPitch = Mathf.Clamp(currentPitch - mouseY * rotationSpeed, minPitch, maxPitch);
        float newYaw = transform.eulerAngles.y + mouseX * rotationSpeed;

        // Set the camera's new rotation
        transform.rotation = Quaternion.Euler(currentPitch, newYaw, 0f);
    }
}
