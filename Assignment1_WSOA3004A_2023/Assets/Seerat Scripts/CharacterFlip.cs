using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
    public Transform object1;
    public Transform object2;

    public GameObject Player;
    public GameObject Opp;
    private bool right;


    void Update()
    {


        float xPosition1 = object1.position.x;
        float xPosition2 = object2.position.x;

        if (xPosition1 > xPosition2)
        {
            right = true;
        }
        else if (xPosition1 < xPosition2)
        {
            right = false;
        }
        else
        {
            right = true;
        }

        if (right)
        {
            object1.transform.rotation = Quaternion.Euler(0, 180, 0);
            object2.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            object1.transform.rotation = Quaternion.Euler(0, 0, 0);
            object2.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
