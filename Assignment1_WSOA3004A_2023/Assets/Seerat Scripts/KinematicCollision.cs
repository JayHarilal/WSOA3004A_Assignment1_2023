using UnityEngine;

public class KinematicCollision : MonoBehaviour
{
    // Reference to the kinematic Rigidbody2D component
    private Rigidbody2D kinematicRigidbody;

    // Store the last position of the kinematic Rigidbody2D
    private Vector2 lastPosition;

    // Check if there was a collision in the previous frame
    private bool wasColliding;

    private void Start()
    {
        // Get the reference to the kinematic Rigidbody2D component
        kinematicRigidbody = GetComponent<Rigidbody2D>();

        // Set the kinematic Rigidbody2D to kinematic mode
        kinematicRigidbody.isKinematic = true;

        // Store the initial position as the last position
        lastPosition = kinematicRigidbody.position;
    }

    private void FixedUpdate()
    {
        // Move the kinematic Rigidbody2D based on the velocity (since it's kinematic)
        kinematicRigidbody.position += kinematicRigidbody.velocity * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If there was no collision in the previous frame, handle collision response
        if (!wasColliding)
        {
            // Get the collision normal and relative velocity
            Vector2 collisionNormal = collision.contacts[0].normal;
            Vector2 relativeVelocity = kinematicRigidbody.velocity - collision.rigidbody.velocity;

            // Calculate the impulse
            float impulseMagnitude = Vector2.Dot(relativeVelocity, collisionNormal);
            Vector2 impulse = collisionNormal * impulseMagnitude;

            // Apply the impulse to the kinematic Rigidbody2D
            kinematicRigidbody.velocity -= impulse;

            // Store the last position as the position before the collision
            lastPosition = kinematicRigidbody.position;

            // Set the flag indicating a collision occurred
            wasColliding = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Reset the flag when the kinematic Rigidbody2D is no longer colliding
        wasColliding = false;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Calculate the displacement from the last position to the current position
        Vector2 displacement = kinematicRigidbody.position - lastPosition;

        // Check if the displacement is different from zero (indicating movement)
        if (displacement != Vector2.zero)
        {
            // Move the kinematic Rigidbody2D back to its last position
            kinematicRigidbody.position = lastPosition;
        }
    }
}
