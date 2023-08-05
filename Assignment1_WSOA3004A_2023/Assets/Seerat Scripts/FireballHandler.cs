using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballHandler : MonoBehaviour
{
    Animator animator;
    public InputStreamer input;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("Hit");
        input.hadoTimer = new FrameTimer(21, input.OnHadoHitComplete);
    }

}
