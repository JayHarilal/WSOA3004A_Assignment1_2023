using UnityEngine;

public class P2Anim : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public ColliderGeneration Hurtbox;
    bool referenced = false;


    private void Initialise()
    {
        Hurtbox.instancedCollider.GetComponent<CollisionHandler>().animControl = this;
    }
    private void AnimationController()
    {

    }

    private void Start()
    {
        if (Hurtbox.instancedCollider == null)
        {
            Hurtbox.Generate();
        }
    }
    private void Update()
    {
        if (Hurtbox.instancedCollider != null && !referenced)
        {
            Initialise();
            referenced = true;
        }
        else if (Hurtbox.instancedCollider != null && referenced)
        {
            Hurtbox.instancedCollider.transform.position = Hurtbox.NewPos();
        }

        AnimationController();
    }
}

