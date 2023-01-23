using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float damage = 50f;
   

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        
    }
    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        var health = othercollider.GetComponent<Health>();
        var attacker = othercollider.GetComponent<LizardWalk>();

        if(attacker && health)
        {
            health.Dealdamage(damage);
            Destroy(gameObject);
        }
        
    }
}
