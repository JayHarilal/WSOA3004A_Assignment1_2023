using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public P2Anim animControl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("nuts");
    }
}
