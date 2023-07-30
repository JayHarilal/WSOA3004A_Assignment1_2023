using UnityEngine;


//Player and Opponent scripts extend from Combatant to add player-specific and opponent-specific functionality
public class Opponent : Combatant
{
    // Function to be called when the opponent performs an attack
    public void Attack()
    {
        // Calculate the position and size of the hitbox relative to the opponent
        Vector2 hitboxPosition = transform.position + new Vector3(-1f, 0f, 0f); // Example offset
        Vector2 hitboxSize = new Vector2(2f, 1f); // Example size

        // Call the CreateHitbox function to instantiate the hitbox
        CreateHitbox(hitboxPosition, hitboxSize, 0.2f); // Example duration
    }

    // Function to be called when the opponent takes damage
    public void TakeDamage()
    {
        // Calculate the position and size of the hurtbox relative to the opponent
        Vector2 hurtboxPosition = transform.position + new Vector3(1f, 0f, 0f); // Example offset
        Vector2 hurtboxSize = new Vector2(2f, 1f); // Example size

        // Call the CreateHurtbox function to instantiate the hurtbox
        CreateHurtbox(hurtboxPosition, hurtboxSize, 0.5f); // Example duration
    }

    // TODO: Implement opponent-specific AI and behavior
}
