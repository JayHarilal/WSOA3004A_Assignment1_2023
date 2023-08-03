using UnityEngine;


public class AnimationController : MonoBehaviour
{
    private Animator animator;

    // Animation states
    private const int IdleState = 0;
    private const int WalkForwardState = 1;
    private const int WalkBackState = 2;
    private const int JumpState = 3;
    private const int ForwardJumpState = 4;
    private const int BackJumpState = 5;
    private const int CrouchState = 6;
    private const int StandingLightPunchState = 7;
    private const int StandingLightKickState = 8;
    private const int CrouchingLightPunchState = 9;
    private const int CrouchingLightKickState = 10;
    private const int JumpingLightPunchState = 11;
    private const int JumpingLightKickState = 12;
    private const int ShoryukenState = 13;
    private const int HadokenState = 14;
    private const int TatsumakiState = 15;



    

    private void Awake()
    {
        animator = GetComponent<Animator>();

        animator.Play("FORWARDJUMP");
    }

    // Call this function to play the Idle animation
    public void PlayIdleAnimation()
    {
        animator.SetInteger("AnimationState", IdleState);
        Debug.Log("playing idle animation");
    }

    // Call this function to play the Walk Forward animation
    public void PlayWalkForwardAnimation()
    {
        animator.SetInteger("AnimationState", WalkForwardState);
        Debug.Log("playing walk forward animation");
    }

    // Call this function to play the Walk Back animation
    public void PlayWalkBackAnimation()
    {
        animator.SetInteger("AnimationState", WalkBackState);
        Debug.Log("playing walk back animation");
    }

    // Call this function to play the Jump animation
    public void PlayJumpAnimation()
    {
        animator.SetInteger("AnimationState", JumpState);
        Debug.Log("playing jump animation");
    }

    // Call this function to play the Forward Jump animation
    public void PlayForwardJumpAnimation()
    {
        animator.SetInteger("AnimationState", ForwardJumpState);
        Debug.Log("playing forward jump animation");
    }

    // Call this function to play the Back Jump animation
    public void PlayBackJumpAnimation()
    {
        animator.SetInteger("AnimationState", BackJumpState);
        Debug.Log("playing back jump animation");
    }

    // Call this function to play the Crouch animation
    public void PlayCrouchAnimation()
    {
        animator.SetInteger("AnimationState", CrouchState);
        Debug.Log("playing crouch animation");
    }

    // Call this function to play the Standing Light Punch animation
    public void PlayStandingLightPunchAnimation()
    {
        animator.SetInteger("AnimationState", StandingLightPunchState);
        Debug.Log("playing standing light punch animation");
    }

    // Call this function to play the Standing Light Kick animation
    public void PlayStandingLightKickAnimation()
    {
        animator.SetInteger("AnimationState", StandingLightKickState);
        Debug.Log("playing standing light kick animation");
    }

    // Call this function to play the Crouching Light Punch animation
    public void PlayCrouchingLightPunchAnimation()
    {
        animator.SetInteger("AnimationState", CrouchingLightPunchState);
        Debug.Log("playing crouch light punch animation");
    }

    // Call this function to play the Crouching Light Kick animation
    public void PlayCrouchingLightKickAnimation()
    {
        animator.SetInteger("AnimationState", CrouchingLightKickState);
        Debug.Log("playing crouching light kick animation");
    }

    // Call this function to play the Jumping Light Punch animation
    public void PlayJumpingLightPunchAnimation()
    {
        animator.SetInteger("AnimationState", JumpingLightPunchState);
        Debug.Log("playing jumping light punch animation");
    }

    // Call this function to play the Jumping Light Kick animation
    public void PlayJumpingLightKickAnimation()
    {
        animator.SetInteger("AnimationState", JumpingLightKickState);
        Debug.Log("playing jumping light kick animation");
    }

    // Call this function to play the Shoryuken animation
    public void PlayShoryukenAnimation()
    {
        animator.SetInteger("AnimationState", ShoryukenState);
        Debug.Log("playing shoryuken animation");
    }

    // Call this function to play the Hadoken animation
    public void PlayHadokenAnimation()
    {
        animator.SetInteger("AnimationState", HadokenState);
        Debug.Log("playing Hadoken animation");
    }

    // Call this function to play the Tatsumaki Sempuukyaku animation
    public void PlayTatsumakiSempuukyakuAnimation()
    {
        animator.SetInteger("AnimationState", TatsumakiState);
        Debug.Log("playing TatsumakiSempuukyaku animation");
    }
}
