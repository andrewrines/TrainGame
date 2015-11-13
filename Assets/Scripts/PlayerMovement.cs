using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5f;

	void Start()
	{
		
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.A))
			transform.Translate(-transform.right * Time.deltaTime * moveSpeed);
		else if (Input.GetKey(KeyCode.D))
			transform.Translate(transform.right * Time.deltaTime * moveSpeed);
	}
}