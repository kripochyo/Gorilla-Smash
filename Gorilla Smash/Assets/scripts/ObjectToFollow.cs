using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed = 5f;
public Transform player;

void Awake()
{
    player = GameObject.FindGameObjectWithTag(“Player”).GetComponent<Transform>();
}


void FixedUpdate()
{
    transform.position = Vector2.moveTowards(transform.position, player.position, speed);
}
}



