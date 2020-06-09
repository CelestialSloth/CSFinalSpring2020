using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZoneWinDetection : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TestCharge"))
        {
            gameManager.CompleteLevel();
        }
    }
}
