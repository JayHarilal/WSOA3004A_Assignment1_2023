using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationStates
{
    Standing,
    Jumping,
    Crouching
}

public class CharacterAnimation : MonoBehaviour
{
    public Animator character;
    public AnimationStates currentState = AnimationStates.Standing;
    public GameObject InputStreamer;

    private void Update()
    {
        AnimationControl();
    }

    private void AnimationControl()
    {
        if (currentState == AnimationStates.Standing)
        {
            if (InputStreamer.GetComponent<InputStreamer>().anim == ATTACKS.standpunch)
            {
                character.SetTrigger("punch");
            }

            if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.right)
            {
                character.SetBool("walk", true);
            }
            else if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.zero)
            {
                character.SetBool("walk", false);
            }

        }
        else if (currentState == AnimationStates.Jumping)
        {

        }
        else if (currentState == AnimationStates.Crouching)
        {

        }
    }
}
