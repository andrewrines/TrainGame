using UnityEngine;
using System.Collections;

public class PlayerInteraction : MonoBehaviour
{
    Ray PointAndClick;

    void Update()
    {
        PointAndClick = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(PointAndClick, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                // interact
                print(hit.transform.name);
            }
        }
    }



    // UUUUUUGGGGGGLLLLYYYYYYY
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "DoorToStaffSleeperCarFromOffice")
        {
            Application.LoadLevel("Office");
        }
        else if (c.tag == "DoorToOfficeFromStaffSleeperCar")
        {
            Application.LoadLevel("StaffSleeperCar");
        }
        else if (c.tag == "")
        {

        }
        else if (c.tag == "")
        {

        }
        else if (c.tag == "")
        {

        }
    }
}
