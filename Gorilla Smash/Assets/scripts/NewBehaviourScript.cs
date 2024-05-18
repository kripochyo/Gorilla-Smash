using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float Speed;
    private Rigidbody RB;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(moveX * Speed, RB.velocity.y);
    }

}
