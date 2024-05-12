using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dlya2lvl : MonoBehaviour
{
    public GameObject walls;
    public GameObject floor;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collaider");
        if (other.gameObject.GetComponent<PlatformerCharacterController>())
        {
            Debug.Log("Player");
            Destroy(walls);
            floor.SetActive(false);
        }
    }
}
