using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllArrowsClass : MonoBehaviour
{
    public Camera cam;
    public Transform arrow;
    public Transform allCharges;

    bool createArrowNextClick = false;

    // Update is called once per frame
    void Update()
    {
        if(createArrowNextClick)
        {
            spawnArrow();
        }
    }

    public void arrowButtonFunction ()
    {
        createArrowNextClick = true;
    }

    public void spawnArrow()
    {
        //spawn an arrow like this... (Eventually spawnArrow should be a function that is called when another button gets pressed)
        //For now it's just in Update
        if (Input.GetMouseButtonDown(0))
        {

            //thing that can send ray from camera through mouse position
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Vector3 eField = allCharges.GetComponent<AllChargeClass>().eFieldAtPoint(hit.point); //calculate e-field at that point
                if (eField.magnitude > 0)
                {
                    Transform newArrow = Instantiate(arrow);
                    newArrow.transform.SetParent(this.transform);

                    //set the efield that the arrow is representing
                    newArrow.GetComponent<ArrowClass>().setUpArrow(hit.point, eField);
                }
                
            }

            createArrowNextClick = false;
        }
    }
}