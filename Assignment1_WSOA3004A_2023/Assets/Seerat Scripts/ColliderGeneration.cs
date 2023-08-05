using System;
using UnityEngine;


public class ColliderGeneration : MonoBehaviour
{
    public Transform topLeftCorner; // Assign in the Inspector
    public Transform bottomRightCorner; // Assign in the Inspector
    public GameObject targetGameObject; // Assign in the Inspector

    public GameObject instancedCollider;

    public void Generate()
    {

        // Calculate the size and center of the box collider
        Vector2 size = new Vector2(
            Mathf.Abs(bottomRightCorner.position.x - topLeftCorner.position.x),
            Mathf.Abs(bottomRightCorner.position.y - topLeftCorner.position.y)
        );


        instancedCollider = Instantiate(targetGameObject, NewPos(), Quaternion.identity);

        // Instantiate the Box Collider on the target GameObject
        BoxCollider2D boxCollider = instancedCollider.AddComponent<BoxCollider2D>();
        boxCollider.size = size;
        boxCollider.offset = new Vector2(0.2f, 0);
        boxCollider.isTrigger = true;
    }

    public Vector2 NewPos()
    {
        Vector2 pos = Vector2.zero;

        pos = new Vector2(
            Mathf.Lerp(topLeftCorner.position.x, bottomRightCorner.position.x, 0.5f),
            Mathf.Lerp(topLeftCorner.position.y, bottomRightCorner.position.y, 0.5f));

        return pos;
    }
}
