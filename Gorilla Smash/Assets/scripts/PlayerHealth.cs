using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    
    public GameObject GameplayUI;
    public GameObject GameOverScreen;
    public Animator animator;
   
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlyerIsDead();
        }
    }

    private void PlyerIsDead()
    {
           GameplayUI.SetActive(false);
           GameOverScreen.SetActive(true);
           GetComponent<PlatformerCharacterController>().enabled = false;
    }
}
