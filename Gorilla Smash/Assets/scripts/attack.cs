using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) animator.SetBool("attack", true);
        else if (Input.GetMouseButtonUp(0)) animator.SetBool("attack", false);
    }
}
