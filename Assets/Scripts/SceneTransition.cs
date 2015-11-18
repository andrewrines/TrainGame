using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{

		if (collider.tag == "SleeperCar1") 
		{
			Application.LoadLevel ("SleeperCar1");
		}

		else if (collider.tag == "SleeperCar2") 
		{
			Application.LoadLevel ("SleeperCar2");
		} 

		else if (collider.tag == "SleeperCar3") 
		{
			Application.LoadLevel ("SleeperCar3");
		}
	}

}
