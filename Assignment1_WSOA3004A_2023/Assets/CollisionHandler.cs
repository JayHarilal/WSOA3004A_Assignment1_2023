using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public P2Anim animControl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "SP(Clone)" ||
            collision.gameObject.name == "SK(Clone)" ||
            collision.gameObject.name == "JP(Clone)" ||
            collision.gameObject.name == "JK(Clone)")
        {
            if (!animControl.midRecovery && !animControl.lowRecovery)
                animControl.midRecovery = true;
            else
                animControl.midDoubleUp = true;
        }
        else if (collision.gameObject.name == "CP(Clone)" ||
            collision.gameObject.name == "CK(Clone)")
        {
            if (!animControl.midRecovery && !animControl.lowRecovery)
                animControl.lowRecovery = true;
            else
                animControl.lowDoubleUp = true;
        }
        else if (collision.gameObject.name == "S(Clone)" ||
            collision.gameObject.name == "T(Clone)" ||
            collision.gameObject.name == "Fireball(Clone)")
        {
            animControl.knockdown = true;
        }
    }
}
