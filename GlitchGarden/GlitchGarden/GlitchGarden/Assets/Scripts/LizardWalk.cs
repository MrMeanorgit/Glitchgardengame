using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardWalk : MonoBehaviour
{
    [Range (0f, 5f)]
    float walkspeed;
    GameObject currenttarget;


    private void Awake()
    {
        FindObjectOfType<levelcontrol>().AttackerSpawned();
    }
    private void OnDestroy()
    {
        levelcontrol level = FindObjectOfType<levelcontrol>();
        if(level != null )
        {
            level.AttackerKilled();
        }
    }
    void Update()
    {
    
        transform.Translate(Vector2.left * walkspeed * Time.deltaTime); //make lizard to walk on left side
        Updateanimestate();
        
    }


    private void Updateanimestate()
    {
        if(!currenttarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        walkspeed = speed; //giving a paricular speed

    }
    public void attack(GameObject target)
    {
      
            GetComponent<Animator>().SetBool("isAttacking", true);
        currenttarget = target;
     
    }


    public void StrikeCurrentTarget(float damage)
    {
        if (!currenttarget) { return; }
        Health health = currenttarget.GetComponent<Health>();
        if (health)
        {
            health.Dealdamage(damage);
        }
    }




}
