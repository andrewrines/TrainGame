using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour
{
    private GameObject[] Doors;
    private GameObject talkingHead;
    void Start()
    {
        Doors = GameObject.FindGameObjectsWithTag("Door");
        talkingHead = GameObject.FindGameObjectWithTag("GUI");
    }

	void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Character")
        {
            print("Press space to talk.");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                c.gameObject.GetComponentInChildren<Renderer>().enabled = true;
                print("something should be happening");
            }
        }

        if (c.tag == "Door")
        {
            print("Press space to go inside the room.");
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    switch (Doors)
            //    {
            //        case Door.Flapper:
            //            Application.LoadLevel("Cabin1");
            //            break;
            //        case Door.MedStudent:
            //            Application.LoadLevel("Cabin2");
            //            break;
            //        default:
            //            print("I can't go in there.");
            //            break;
            //    }
            //}
        }
    }

    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Character")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                talkingHead.GetComponent<GUIElement>().enabled = true;
                print("something should be happening");
            }
        }
    }
}
