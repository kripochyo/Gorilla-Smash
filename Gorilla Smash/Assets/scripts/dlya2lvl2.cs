using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dlya2lvl2 : MonoBehaviour
{
    public GameObject floor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlatformerCharacterController>())
        {
            floor.SetActive(true);
        }
    }
}
