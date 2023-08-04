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

        if (character.GetInteger("state") == 0)
        {
            currentState = AnimationStates.Standing;
            InputStreamer.GetComponent<InputStreamer>().charState = STATES.standing;
        }
        else if (character.GetInteger("state") == 1)
        {
            currentState = AnimationStates.Jumping;
            InputStreamer.GetComponent<InputStreamer>().charState = STATES.jumping;
        }
        else
        {
            currentState = AnimationStates.Crouching;
            InputStreamer.GetComponent<InputStreamer>().charState = STATES.crouching;
        }

        AnimationControl();

        if (character.GetInteger("state") == 0 && character.GetBool("walk") == true ||
            character.GetInteger("state") == 0 && character.GetBool("backwalk") == true ||
            character.GetInteger("state") == 0 && InputStreamer.GetComponent<InputStreamer>().readInput)

        {
            character.gameObject.transform.position = new Vector3(character.gameObject.transform.position.x,
                -2f,
                character.gameObject.transform.position.z);
        }
    }

    private void AnimationControl()
    {
        if (InputStreamer.GetComponent<InputStreamer>().readInput)
            if (currentState == AnimationStates.Standing)
            {

                if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.down)
                {
                    character.SetInteger("state", 2);
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == new Vector2(-0.707107f, -0.707107f))
                {
                    character.SetInteger("state", 2);
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == new Vector2(0.707107f, -0.707107f))
                {
                    character.SetInteger("state", 2);
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.up)
                {
                    character.SetInteger("state", 1);
                    character.SetTrigger("ujump");
                    InputStreamer.GetComponent<InputStreamer>().jumpTimer =
                        new FrameTimer(56, InputStreamer.GetComponent<InputStreamer>().OnJumpComplete);
                    InputStreamer.GetComponent<InputStreamer>().jumping = true;
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == new Vector2(0.707107f, 0.707107f))
                {
                    character.SetInteger("state", 1);
                    character.SetTrigger("fjump");
                    InputStreamer.GetComponent<InputStreamer>().jumpTimer =
                        new FrameTimer(56, InputStreamer.GetComponent<InputStreamer>().OnJumpComplete);
                    InputStreamer.GetComponent<InputStreamer>().jumping = true;
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == new Vector2(-0.707107f, 0.707107f))
                {
                    character.SetInteger("state", 1);
                    character.SetTrigger("bjump");
                    InputStreamer.GetComponent<InputStreamer>().jumpTimer =
                        new FrameTimer(56, InputStreamer.GetComponent<InputStreamer>().OnJumpComplete);
                    InputStreamer.GetComponent<InputStreamer>().jumping = true;
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.right)
                {
                    character.SetBool("walk", true);
                    character.SetBool("backwalk", false);
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.left)
                {
                    character.SetBool("walk", false);
                    character.SetBool("backwalk", true);
                }
                else if (InputStreamer.GetComponent<InputStreamer>().directionInput == Vector2.zero)
                {
                    character.SetBool("walk", false);
                    character.SetBool("backwalk", false);
                    character.SetInteger("state", 0);
                }

            }
            
            else if (currentState == AnimationStates.Crouching)
            {

                if (InputStreamer.GetComponent<InputStreamer>().directionInput != Vector2.down &&
                    InputStreamer.GetComponent<InputStreamer>().directionInput != new Vector2(-0.707107f, -0.707107f) &&
                    InputStreamer.GetComponent<InputStreamer>().directionInput != new Vector2(0.707107f, -0.707107f))
                {
                    character.SetInteger("state", 0);
                }
            }
    }
}
