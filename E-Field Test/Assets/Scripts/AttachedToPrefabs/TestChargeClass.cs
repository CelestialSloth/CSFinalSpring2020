using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChargeClass : MonoBehaviour
{
    public Vector3 velocity;
    public Quaternion offsetRotation = Quaternion.Euler(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        //move at some set velocity
        transform.Translate(velocity * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0); //remove in future versions
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Arrow"))
        {
            //change movement direction to direction of e-field arrow
            velocity = 0.0000001f * other.GetComponent<ArrowClass>().eFieldHere; //okay, so not the *most* accurate thing ever
            //transform.rotation = other.transform.rotation * offsetRotation;
        }
    }
}
