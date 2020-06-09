using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ChargeClass : MonoBehaviour
{
    public double k = 9.0 * Mathf.Pow(10, 9);

    public double chargeValue;
    public GameObject physicalForm;
    public Material posMat, negMat;

    //When the thing starts, change the color of the charge based on + or -
    void Start()
    {
        if (chargeValue > 0)
        {
            physicalForm.GetComponent<MeshRenderer>().material = posMat;
        }
        else
        {
            physicalForm.GetComponent<MeshRenderer>().material = negMat;
        }
    }

    //calculate electric field from THIS charge at some position
    public Vector3 myEFieldAtPoint(Vector3 p)
    {
        double distSquared = (p - physicalForm.transform.position).sqrMagnitude;
        double magnitude = k * chargeValue / distSquared;


        //return unit vector * magnitude
        return (p - physicalForm.transform.position).normalized * (float) magnitude;
    }
}
