using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance; 

	// Use this for initialization
	void Awake () 
	{

		if (instance == null) {
			instance = this;
		} else if (instance != this) 
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad (gameObject);



	}
    void OnLevelWasLoaded (int Level)
    {
        switch (Level)
        {
            case 0:
                GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(1, 0, 0);
                break;
        }
    }
	
	// Update is called once per frame
	void Update () 
	{

	}
}