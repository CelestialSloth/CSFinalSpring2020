using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReportChargeNumbers : MonoBehaviour
{
    int numNegChargesLeft, numPosChargesLeft, numTotalChargesLeft;
    public Text pText, nText/*, tText*/;
    AllChargeClass allChargeClass;

    void Awake()
    {
        allChargeClass = gameObject.GetComponentInParent<AllChargeClass>();
    }

    // Update is called once per frame
    void Update()
    {
        //update number of charges left in each category. Doing this every frame rather than every click or something
        numNegChargesLeft = allChargeClass.numNegChargesAllowed - allChargeClass.numNegCharges;
        numPosChargesLeft = allChargeClass.numPosChargesAllowed - allChargeClass.numPosCharges;
        numTotalChargesLeft = allChargeClass.numTotalChargesAllowed - allChargeClass.numTotalCharges;

        pText.text = reportPosChargesLeft();
        nText.text = reportNegChargesLeft();
        //tText.text = reportChargesLeft;
    }

    //how to report the charges for the text...I feel like I should put this somewhere else but not really sure where...
    public string reportPosChargesLeft()
    {
        if (allChargeClass.numPosChargesAllowed >= 0)
        {
            return numPosChargesLeft.ToString();
        }
        else
        {
            return "inf";
        }

    }
    public string reportNegChargesLeft()
    {
        if (allChargeClass.numNegChargesAllowed >= 0)
        {
            return numNegChargesLeft.ToString();
        }
        else
        {
            return "inf";
        }

    }
    public string reportChargesLeft()
    {
        if (allChargeClass.numTotalChargesAllowed >= 0)
        {
            return numTotalChargesLeft.ToString();
        }
        else
        {
            return "inf";
        }

    }
}
