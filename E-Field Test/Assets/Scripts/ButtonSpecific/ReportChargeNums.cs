using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportChargeNums : MonoBehaviour
{
    int numNegChargesLeft, numPosChargesLeft, numTotalChargesLeft;
    public Transform AllChargeClass;
    //public Text pText, nText, tText;
    /*public AllChargeClass refScript = AllChargeClass.GetComponent<AllChargeClass>();


    // Update is called once per frame
    void Update()
    {
        numNegChargesLeft = refScript.numNegChargesAllowed - refScript.numNegCharges;
        numPosChargesLeft = refScript.numPosChargesAllowed - refScript.numPosCharges;
        numTotalChargesLeft = refScript.numTotalChargesAllowed - refScript.numTotalCharges;
    }

    //how to report the charges for the text...I feel like I should put this somewhere else but not really sure where...
    public string reportPosChargesLeft()
    {
        if (refScript.numPosChargesAllowed >= 0)
        {
            return (numPosChargesLeft).ToString();
        }
        else
        {
            return "inf";
        }

    }
    public string reportNegChargesLeft()
    {
        if (refScript.numNegChargesAllowed >= 0)
        {
            return (numNegChargesLeft).ToString();
        }
        else
        {
            return "inf";
        }

    }
    public string reportChargesLeft()
    {
        if (refScript.numTotalChargesAllowed >= 0)
        {
            return (numTotalChargesLeft).ToString();
        }
        else
        {
            return "inf";
        }

    }*/
}
