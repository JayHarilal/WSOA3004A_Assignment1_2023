using UnityEngine;

public class BoxColliderFromTransforms : MonoBehaviour
{
    public Transform topLeftCorner; // Assign in the Inspector
    public Transform bottomRightCorner; // Assign in the Inspector
    public GameObject targetGameObject; // Assign in the Inspector

    void Start()
    {
        if (topLeftCorner == null || bottomRightCorner == null)
        {
            Debug.LogError("Please assign both top-left and bottom-right transforms.");
            return;
        }

        if (targetGameObject == null)
        {
            Debug.LogError("Please assign the target GameObject where the Box Collider will be instantiated.");
            return;
        }

        // Calculate the size and center of the box collider
        Vector3 size = new Vector3(
            Mathf.Abs(topLeftCorner.position.x - bottomRightCorner.position.x),
            Mathf.Abs(topLeftCorner.position.y - bottomRightCorner.position.y),
            Mathf.Abs(topLeftCorner.position.z - bottomRightCorner.position.z)
        );

        Vector3 center = new Vector3(
            (topLeftCorner.position.x + bottomRightCorner.position.x) / 2f,
            (topLeftCorner.position.y + bottomRightCorner.position.y) / 2f,
            (topLeftCorner.position.z + bottomRightCorner.position.z) / 2f
        );

        // Instantiate the Box Collider on the target GameObject
        BoxCollider boxCollider = targetGameObject.AddComponent<BoxCollider>();
        boxCollider.size = size;
        boxCollider.center = center;
    }
}
