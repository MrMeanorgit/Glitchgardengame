using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<GraveStone>())
        {
            GetComponent<Animator>().SetTrigger("isTriggered");
        }

        else if (otherObject.GetComponent<Defende>())
        {
            GetComponent<LizardWalk>().attack(otherObject);
        }
    }
}

