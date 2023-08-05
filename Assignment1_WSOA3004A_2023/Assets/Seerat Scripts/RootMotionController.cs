using UnityEngine;

public class RootMotionController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Get the root motion delta position and rotation from the animator
        Vector2 deltaPosition = animator.deltaPosition;
        float deltaRotation = animator.deltaRotation.eulerAngles.z;

        // Update the object's position and rotation manually
        transform.position += (Vector3)deltaPosition;
        transform.Rotate(Vector3.forward, deltaRotation);
    }
}
