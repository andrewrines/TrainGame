using UnityEngine;
using System.Collections;

public class DoorsBetweenCars : MonoBehaviour
{
    void OnTriggerEnter (Collider c)
    {
        
        if (c.tag == "RightDoor")
        {
            transform.position += new Vector3(2, 0, 0);
        }
        else if (c.tag == "LeftDoor")
        {
            transform.position += new Vector3(-2, 0, 0);
        }
        else if (c.tag == "DoorToCabin1Car1") // etc.
        {
            // for any cabin, simply overlay an image GUI on the existing scene
        }
    }
}
