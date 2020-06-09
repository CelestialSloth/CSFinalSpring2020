using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Camera cam;
    public Transform testCharge;
    public Transform startShooter;
    public Vector3 startVelocity;

    public void startButtonFunction()
    {
        Transform q = Instantiate(testCharge);
        q.transform.localPosition = startShooter.transform.position;
        //change test charge velocity
        q.transform.GetComponent<TestChargeClass>().velocity = startVelocity;
    }
}
