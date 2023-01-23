using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    [SerializeField] GameObject projectile;
    AttckerSpawner mylanespawner;
    Animator animator;
    GameObject projectileparenrts;
    const string NEW_PROJECTILE_PARENT = "Projectile";
    private void createprojectilespawner()
    {
        projectileparenrts = GameObject.Find(NEW_PROJECTILE_PARENT);
        if (!projectileparenrts)
        {
            projectileparenrts = new GameObject(NEW_PROJECTILE_PARENT);
        }
    }

    public void Start()
    {
        Setlanespawner();
        animator = GetComponent<Animator>();
        createprojectilespawner();
    }

    private void Update()
    {
        if (IsAttackerInLane()) 
        {
            
            animator.SetBool("isattacking", true);
        }
        else
        {
            
            animator.SetBool("isattacking", false);
        }
    }
    private void Setlanespawner()
    {
        AttckerSpawner[] spawner = FindObjectsOfType<AttckerSpawner>();
        foreach(AttckerSpawner spawne in spawner)
        {
            bool closeenough = (Mathf.Abs (spawne.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if(closeenough)
            {
                mylanespawner = spawne;
            }

        }
    }
    private bool IsAttackerInLane()
    {
       
        if (mylanespawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void Fire()
    {
      GameObject projectiles =  Instantiate(projectile, transform.position, transform.rotation) as GameObject; //spawns the zuccini at certain anime event in the cactus
        projectiles.transform.parent = projectileparenrts.transform;
    }
}
