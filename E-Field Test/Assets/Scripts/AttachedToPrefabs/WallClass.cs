using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClass : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TestCharge"))
        {
            Destroy(other.gameObject);
        }
    }

}
