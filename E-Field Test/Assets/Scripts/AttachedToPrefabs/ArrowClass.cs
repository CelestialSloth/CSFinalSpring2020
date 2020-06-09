using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClass : MonoBehaviour
{
    public Vector3 eFieldHere;
    
    public void setUpArrow(Vector3 pos, Vector3 eField)
    {
        eFieldHere = eField;
        transform.position = pos;

        Vector3 fromVector = new Vector3(0, 1, 0);
        transform.rotation = Quaternion.FromToRotation(fromVector, eFieldHere);
    }
}
