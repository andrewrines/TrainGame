using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO HANDLE POINT-AND-CLICK INTERACTION - APPLY THIS SCRIPT TO THE PLAYER

public class PointAndClickInteraction : MonoBehaviour
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
                transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y), hit.transform.position, 3 * Time.deltaTime);  // hit only exists for a fraction of a second, so imogene only kind of inches toward her goal. also, I think you can't move around the car by clicking because you can't "moveTowards" a gameObject that you're already technically standing on (the traincar)
                print(hit.transform.name);
            }
        }
    }
}
