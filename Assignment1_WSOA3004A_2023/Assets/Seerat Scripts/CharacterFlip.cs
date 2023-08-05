using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
    public Transform object1;
    public Transform object2;

    public GameObject Player;
    public GameObject Opp;
    public bool facingRight = true; // Assuming the character starts facing right initially
    public InputStreamer input;
    public bool flipping = false;

    void Update()
    {
        float xPosition1 = object1.position.x;
        float xPosition2 = object2.position.x;

        if (xPosition1 < xPosition2 && !facingRight && !flipping)
        {
            Invoke("FlipCharacter", 0.4f);
            flipping = true;
        }
        else if (xPosition1 > xPosition2 && facingRight && !flipping)
        {

            Invoke("FlipCharacter", 0.4f);
            flipping = true;
        }


    }

    void FlipCharacter()
    {
        facingRight = !facingRight;

        // Flip the character sprite horizontally
        //Vector3 scale = transform.localScale;
        //scale.x *= -1;
        //transform.localScale = scale;
        Vector3 scale1 = object1.transform.localScale;
        Vector3 scale2 = object2.transform.localScale;

        scale1.x *= -1;
        scale2.x *= -1;

        object1.transform.localScale = scale1;
        object2.transform.localScale = scale2;

        // Update the facing direction in the InputStreamer script if needed
        input.facingRight = facingRight;
        flipping = false;
    }
}
