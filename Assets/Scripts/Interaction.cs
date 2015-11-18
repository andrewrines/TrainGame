using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

    Ray PointAndClick;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        PointAndClick = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(PointAndClick, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                print(name);
            }
        }
	}
}
