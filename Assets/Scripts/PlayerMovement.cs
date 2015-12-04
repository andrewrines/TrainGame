using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2;
    
	public PlayerMovement PlayerInstance = null;
    
    void Awake()
    {
		if (PlayerInstance == null)
			PlayerInstance = this;
		else if (PlayerInstance != this)
			Destroy(gameObject);
		
		DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right * Time.deltaTime * Speed);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * Time.deltaTime * Speed);
    }
}