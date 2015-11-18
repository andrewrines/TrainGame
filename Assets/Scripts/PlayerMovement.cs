using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< HEAD
    public float Speed = 2;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right * Time.deltaTime * Speed);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * Time.deltaTime * Speed);
    }
}
=======
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
        DontDestroyOnLoad(gameObject);
	}
}
>>>>>>> 97073c00fa771e6f47be2334e43a9ab72357e8ae
