using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	Vector3 SpawnPosition;

	// Use this for initialization
	void Start () 
	{
		SpawnPosition = GameObject.FindGameObjectWithTag("Spawn").transform.position;
		Instantiate (Resources.Load("Art/Player"), SpawnPosition, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}