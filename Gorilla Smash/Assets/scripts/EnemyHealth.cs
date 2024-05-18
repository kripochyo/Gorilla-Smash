using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int value = 10;
   

    public void DealDamage(int damage)
    {
        value -= damage;
        Debug.Log("EnemyHealth " + value);
        if(value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
