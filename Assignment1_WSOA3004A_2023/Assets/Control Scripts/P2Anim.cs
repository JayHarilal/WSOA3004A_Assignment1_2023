using System;
using UnityEngine;

public class P2Anim : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public ColliderGeneration Hurtbox;
    public FrameTimer OTG;
    public FrameTimer Recov;
    public OpponentHealth HP;
    bool referenced = false;
    bool animLock = false;
    public bool midRecovery = false;
    public bool lowRecovery = false;
    public bool knockdown = false;
    public bool midDoubleUp = false;
    public bool lowDoubleUp = false;


    private void Initialise()
    {
        Hurtbox.instancedCollider.GetComponent<CollisionHandler>().animControl = this;
    }
    private void AnimationController()
    {
        if (!animLock)
            if (midRecovery)
            {
                animLock = true;
                animator.Play("MidHit");
                HP.currentHealth -= 5;

            }
            else if (lowRecovery)
            {
                animLock = true;
                animator.Play("LowHit");
                HP.currentHealth -= 7;
            }
            else if (knockdown)
            {
                animLock = true;
                animator.Play("Knockdown");
                HP.currentHealth -= 15;
            }
    }

    public void Combo()
    {
        if (lowDoubleUp)
        {
            Recov = new FrameTimer(31, OnRecovComplete);
            animator.Play("LowHit");
            HP.currentHealth -= 5;
            lowDoubleUp = false;
        }
        else if (midDoubleUp)
        {
            Recov = new FrameTimer(31, OnRecovComplete);
            animator.Play("MidHit");
            HP.currentHealth -= 3;
            midDoubleUp = false;
        }

        if (lowRecovery || midRecovery)
        {
            if (knockdown)
            {
                OTG = new FrameTimer(91, OnKnockdownComplete);
                animator.Play("Knockdown");
                HP.currentHealth -= 10;
                lowRecovery = false;
                midRecovery = false;
            }
        }

        lowDoubleUp = false;
        midDoubleUp = false;
    }
    private void Start()
    {
        if (Hurtbox.instancedCollider == null)
        {
            Hurtbox.Generate();
        }
        OTG = new FrameTimer(91, OnKnockdownComplete);
        Recov = new FrameTimer(31, OnRecovComplete);

    }

    private void OnRecovComplete()
    {
        animator.Play("idle");
        animator.gameObject.transform.position = new Vector3(animator.gameObject.transform.position.x,
            -2f, animator.gameObject.transform.position.z);
        animLock = false;
        midRecovery = false;
        lowRecovery = false;
        Recov = new FrameTimer(31, OnRecovComplete);
    }

    private void OnKnockdownComplete()
    {
        animator.Play("idle");
        animator.gameObject.transform.position = new Vector3(animator.gameObject.transform.position.x,
            -2f, animator.gameObject.transform.position.z);
        animLock = false;
        knockdown = false;
        OTG = new FrameTimer(91, OnKnockdownComplete);
    }

    private void LateUpdate()
    {
        AnimationController();

        Combo();
        if (midRecovery && animLock || lowRecovery && animLock)
        {
            Recov.Update();
        }
        else if (knockdown && animLock)
        {
            OTG.Update();
        }

        if (Hurtbox.instancedCollider != null && !referenced)
        {
            Initialise();
            referenced = true;
        }
        else if (Hurtbox.instancedCollider != null && referenced)
        {
            Hurtbox.instancedCollider.transform.position = Hurtbox.NewPos();
        }



    }
}

