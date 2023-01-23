using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    // Start is called before the first frame update
 // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        GameObject otherobject = othercollider.gameObject;
        if(otherobject.GetComponent<Defende>())
        {
            GetComponent<LizardWalk>().attack(otherobject);
        }
    }
}
