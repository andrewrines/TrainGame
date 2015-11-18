using UnityEngine;
using System.Collections;
using System.Collections.Generic;

<<<<<<< HEAD
public class GameManager : MonoBehaviour
{
    enum PreviousLocation { Office, StaffSleeperCar, Kitchen, DiningCar, SleeperCar1, SleeperCar2, SleeperCar3, LuggageCar, Caboose };

    PreviousLocation SpawnPoint;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnLevelWasLoaded(int Level)
=======
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
>>>>>>> 97073c00fa771e6f47be2334e43a9ab72357e8ae
    {
        switch (Level)
        {
            case 0:
<<<<<<< HEAD
                if (SpawnPoint == PreviousLocation.SleeperCar1)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(0, 0, 0);
                }
                else if (SpawnPoint == PreviousLocation.SleeperCar2)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(0, 0, 0);
                }
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
        }
    }

}
=======
                GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(1, 0, 0);
                break;
        }
    }
	
	// Update is called once per frame
	void Update () 
	{

	}
}
>>>>>>> 97073c00fa771e6f47be2334e43a9ab72357e8ae
