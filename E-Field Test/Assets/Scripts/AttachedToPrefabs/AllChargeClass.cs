using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllChargeClass : MonoBehaviour
{
    bool createChargeOnClick = false;
    public Transform chargeTransform;
    public Camera cam;
    public bool nextChargeIsPositive;

    //how to restrict charge creation if necessary. Set the "allowed" vars to < 0 if there is no value. (Apparently I can't set them to null?)
    public int numPosChargesAllowed = -1;
    public int numNegChargesAllowed = -1;
    public int numTotalChargesAllowed = -1;
    public int numPosCharges, numNegCharges, numTotalCharges;

    void Update()
    {
        countCharges();

        if(createChargeOnClick) { spawnCharge(nextChargeIsPositive); }
    }
    public Vector3 eFieldAtPoint(Vector3 location)
    {
        Vector3 eField = new Vector3(0, 0, 0);
        for(int i = 0; i < transform.childCount; i ++)
        {
            eField += transform.GetChild(i).GetComponent<ChargeClass>().myEFieldAtPoint(location);
        }
        return eField;
    }

    /******************BUTTON STUFF****************************************/
    //*Maybe* put this in a different script
    //when the button is clicked, we just want to toggle this bool. Everything else is taken care of in Update.
    public void posChargeButtonFunction()
    {
        //note: we are assuming that EITHER there is a limit to positive charges OR a limit to total charges--not both
        if((numPosChargesAllowed < 0 && numTotalChargesAllowed < 0) || numPosCharges < numPosChargesAllowed || numTotalCharges < numTotalChargesAllowed)
        {
            createChargeOnClick = true;
            nextChargeIsPositive = true;
        }
    }

    public void negChargeButtonFunction()
    {
        //notes: assuming that EITHER there's a limit to negative charges OR a limit to total charges--not both
        if ((numNegChargesAllowed < 0 && numTotalChargesAllowed < 0) || numNegCharges < numNegChargesAllowed || numTotalCharges < numTotalChargesAllowed)
        {
            createChargeOnClick = true;
            nextChargeIsPositive = false;
        }
        
    }

    //How to actually create a new charge
    public void spawnCharge(bool positive)
    {
        if (Input.GetMouseButtonDown(0))
        {
            //thing that can send ray from camera through mouse position
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //only go through with everything if it actually hits something close
            if (Physics.Raycast(ray, out hit, 100) && hit.transform.tag == "Stopper")
            {
                Transform newCharge = Instantiate(chargeTransform);

                //is it + or -?
                if (!positive) { newCharge.transform.GetComponent<ChargeClass>().chargeValue = -1; }
                else { newCharge.transform.GetComponent<ChargeClass>().chargeValue = 1; }

                newCharge.transform.SetParent(this.transform);
                //set location.
                newCharge.transform.localPosition = hit.point;
            }

            //turn it off
            createChargeOnClick = false;
        }
    }

    public void countCharges()
    {
        numTotalCharges = transform.childCount;
        numNegCharges = 0; numPosCharges = 0; //reset charge counts
        for(int i = 0; i < numTotalCharges; i++)
        {
            if(transform.GetChild(i).GetComponent<ChargeClass>().chargeValue < 0)
            {
                numNegCharges++;
            }else
            {
                numPosCharges++; //no neutral charges here...that'd be pointless and confusing
            }
        }
    }

    
}
