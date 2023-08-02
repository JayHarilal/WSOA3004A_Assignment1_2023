using UnityEngine;
using System.Collections.Generic; // to include the List<> class

// Combatant script contains the common functionality for creating and managing colliders
//Player and Opponent scripts extend from Combatant to add player-specific and opponent-specific functionality
public class Combatant : MonoBehaviour
{
    // Prefabs for hitboxes and hurtboxes
    public GameObject hitboxPrefab;
    public GameObject hurtboxPrefab;

    // Lists to store instantiated hitboxes and hurtboxes
    protected List<GameObject> hitboxes = new List<GameObject>();
    protected List<GameObject> hurtboxes = new List<GameObject>();

    // Function to instantiate a hitbox
    protected void CreateHitbox(Vector2 position, Vector2 size, float duration)
    {
        GameObject hitbox = Instantiate(hitboxPrefab, position, Quaternion.identity);
        hitbox.transform.localScale = size;
        Destroy(hitbox, duration);
        hitboxes.Add(hitbox);
    }

    // Function to instantiate a hurtbox
    protected void CreateHurtbox(Vector2 position, Vector2 size, float duration)
    {
        GameObject hurtbox = Instantiate(hurtboxPrefab, position, Quaternion.identity);
        hurtbox.transform.localScale = size;
        Destroy(hurtbox, duration);
        hurtboxes.Add(hurtbox);
    }

    // Function to clear all hitboxes and hurtboxes
    protected void ClearColliders()
    {
        foreach (GameObject hitbox in hitboxes)
        {
            Destroy(hitbox);
        }
        hitboxes.Clear();

        foreach (GameObject hurtbox in hurtboxes)
        {
            Destroy(hurtbox);
        }
        hurtboxes.Clear();
    }

    // TODO: Implement combat actions such as attack and take damage functions
}
