using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    Animator animator;

    public float damage = 100;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
    }

    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) animator.SetBool("attack", true);
        {
            damage;
        }
    }
}
