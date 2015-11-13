using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour
{
    private GameObject talkingHead;

    Ray playerRay;


    void Start()
    {
        talkingHead = GameObject.FindGameObjectWithTag("GUI");
    }

    void Update()
    {
        playerRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(playerRay, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                print(hit.transform.gameObject.name);
            }
        }
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
        else if (c.tag == "FlapperDoor" || c.tag == "StudentDoor")
        {
            print("Press space to go inside the room.");
        }
    }

    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Character" && Input.GetKeyDown(KeyCode.Space))
        {
            // pull up the character gui
        }
        else if (c.tag == "StudentDoor" && Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Cabin1");
        }
        else if (c.tag == "SleeperCar1")
        {
            
        }
    }
}
