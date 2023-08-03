using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform character1; // The first character to follow
    public Transform character2; // The second character to follow
    public Vector2 offset = new Vector2(0f, 1f); // Offset from the average character position
    public float smoothSpeed = 0.1f; // Smoothing speed of camera movement

    public float minCameraX; // The minimum X position the camera can have
    public float maxCameraX; // The maximum X position the camera can have
    public float minCameraY; // The minimum Y position the camera can have
    public float maxCameraY; // The maximum Y position the camera can have

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        // Check if both characters exist
        if (character1 == null || character2 == null)
        {
            Debug.LogWarning("Both characters are not set!");
            return;
        }

        // Calculate the average position of both characters
        Vector3 averagePosition = (character1.position + character2.position) / 2f;

        // Calculate the target position with offset
        Vector3 targetPosition = new Vector3(averagePosition.x + offset.x, averagePosition.y + offset.y, transform.position.z);

        // Clamp the target position to camera bounds
        float clampedX = Mathf.Clamp(targetPosition.x, minCameraX, maxCameraX);
        float clampedY = Mathf.Clamp(targetPosition.y, minCameraY, maxCameraY);
        targetPosition = new Vector3(clampedX, clampedY, transform.position.z);

        // Smoothly move the camera to the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);
    }
}
