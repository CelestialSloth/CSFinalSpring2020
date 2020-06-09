using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    bool deleteObjectNextClick = false;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if(deleteObjectNextClick)
        {
            //if mouse is clicked
            if (Input.GetMouseButtonDown(0))
            {
                //thing that can send ray from camera through mouse position
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                //only delete if it hits something close (too far away and we don't know what you were aiming for)
                if (Physics.Raycast(ray, out hit, 100) && isDeletable(hit.transform.gameObject.tag))
                {
                    Destroy(hit.transform.gameObject);
                }

                //turn it off
                deleteObjectNextClick = false;
            }
        }
    }

    //determine if tag is deletable--UNTESTED
    bool isDeletable(string tag)
    {
        string[] deletableThings = { "Deletable", "FixedCharge", "Arrow" };
        bool canDelete = false;

        for(int i = 0; i < deletableThings.Length; i ++)
        {
            if(tag == deletableThings[i])
            {
                canDelete = true;
            }
        }

        return canDelete;
    }

    public void deleteButtonFunction()
    {
        deleteObjectNextClick = true;
    }
}
