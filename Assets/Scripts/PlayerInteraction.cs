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
}
