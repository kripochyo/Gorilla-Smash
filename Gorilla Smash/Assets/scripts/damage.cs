﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int Damage = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().DealDamage(Damage);
        }
    }
}
