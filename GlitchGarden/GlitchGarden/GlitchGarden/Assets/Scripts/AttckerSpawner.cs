using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttckerSpawner : MonoBehaviour
{
    [SerializeField] float maxspwandelay = 1f;
    [SerializeField] float minspwandelay = 5f;
    [SerializeField] LizardWalk[] attackerprefab;

    bool spawn = true;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minspwandelay, maxspwandelay));  //random spawn process
            spawnAttacker();
        }
    }
    public void StopSpawning()
    {
        spawn = false;
    }

    private void spawnAttacker() //spawning the lizard 
    {
        var attackerindex = Random.Range(0, attackerprefab.Length);
        spawnit(attackerprefab[attackerindex]);
    }

    private void spawnit(LizardWalk attacker)
    {
        LizardWalk newAttacker = Instantiate(attacker, transform.position, transform.rotation) as LizardWalk;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
   
}
