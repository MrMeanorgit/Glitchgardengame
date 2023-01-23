using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveStone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        LizardWalk attacker = otherCollider.GetComponent<LizardWalk>();

        if (attacker)
        {
            // TODO Add some sort of animation
        }

    }
}
