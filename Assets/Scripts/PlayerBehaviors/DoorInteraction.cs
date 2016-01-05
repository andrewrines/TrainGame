using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO HANDLE SCENE TRANSITIONS VIA DOOR GAMEOBJECTS - APPLY THIS SCRIPT TO THE PLAYER

public class DoorInteraction : MonoBehaviour
{
    bool imhighasfuck = false;

    void Update()
    {
        if (imhighasfuck)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel("SleeperCar1");
                imhighasfuck = false;
            }
        }
    }

    void OnTriggerStay(Collider c)
    {
        if (c.tag == "DoorToOfficeFromStaffSleeperCar")
        {
            Application.LoadLevel("Office");
            GetComponent<Transform>().position = new Vector3(-3, 0, 0);
        }
        else if (c.tag == "DoorToStaffSleeperCarFromOffice")
        {
            Application.LoadLevel("StaffSleeperCar");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        else if (c.tag == "DoorToStaffSleeperCarFromDiningCar")
        {
            Application.LoadLevel("StaffSleeperCar");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToDiningCarFromStaffSleeperCar")
        {
            Application.LoadLevel("DiningCar");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        else if (c.tag == "DoorToDiningCarFromSleeperCar1")
        {
            Application.LoadLevel("DiningCar");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToSleeperCar1FromDiningCar")
        {
            Application.LoadLevel("SleeperCar1");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                  CABINS
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        else if (c.tag == "DoorToCabin1Car1")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                imhighasfuck = true;
                Application.LoadLevel("Cabin1Car1");
                GetComponent<Transform>().position = new Vector3(0, 0, 0);
            }
        }
        else if (c.tag == "ExitCabin1Car1")
        {
            Application.LoadLevel("SleeperCar1");
        }

        else if (c.tag == "DoorToCabin2Car1")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                imhighasfuck = true;
                Application.LoadLevel("Cabin2Car1");
                GetComponent<Transform>().position = new Vector3(0, 0, 0);
            }
        }
        else if (c.tag == "ExitCabin2Car1")
        {
            Application.LoadLevel("SleeperCar1");
        }

        else if (c.tag == "DoorToCabin3Car1")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                imhighasfuck = true;
                Application.LoadLevel("Cabin3Car1");
                GetComponent<Transform>().position = new Vector3(0, 0, 0);
            }
        }
        else if (c.tag == "ExitCabin3Car1")
        {
            Application.LoadLevel("SleeperCar1");
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                  NOT CABINS
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        else if (c.tag == "DoorToSleeperCar1FromSleeperCar2")
        {
            Application.LoadLevel("SleeperCar1");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToSleeperCar2FromSleeperCar1")
        {
            Application.LoadLevel("SleeperCar2");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        else if (c.tag == "DoorToSleeperCar2FromSleeperCar3")
        {
            Application.LoadLevel("SleeperCar2");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToSleeperCar3FromSleeperCar2")
        {
            Application.LoadLevel("SleeperCar3");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        else if (c.tag == "DoorToSleeperCar3FromLuggageCar")
        {
            Application.LoadLevel("SleeperCar3");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToLuggageCarFromSleeperCar3")
        {
            Application.LoadLevel("LuggageCar");
            GetComponent<Transform>().position = new Vector3(5.64f, 0, 0);
        }

        else if (c.tag == "DoorToLuggageCarFromCaboose")
        {
            Application.LoadLevel("LuggageCar");
            GetComponent<Transform>().position = new Vector3(-5.96f, 0, 0);
        }
        else if (c.tag == "DoorToCabooseFromLuggageCar")
        {
            Application.LoadLevel("Caboose");
            GetComponent<Transform>().position = new Vector3(2.08f, 0, 0);
        }
    }
}
