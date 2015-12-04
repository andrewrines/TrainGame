using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    enum PreviousLocation { Office, StaffSleeperCar, Kitchen, DiningCar, SleeperCar1, SleeperCar2, SleeperCar3, LuggageCar, Caboose };

    PreviousLocation PrevLoc;
    
	public GameManager ManagerInstance = null;

    void Awake()
    {
        if (ManagerInstance == null)
            ManagerInstance = this;
        else if (ManagerInstance != this)
			Destroy(gameObject);
		
		DontDestroyOnLoad(gameObject);
    }

    void OnLevelWasLoaded (int Level)
        {
        switch (Level)
        {
            case 0:
                if (PrevLoc == PreviousLocation.SleeperCar1)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(0, 0, 0);
                }
                else if (PrevLoc == PreviousLocation.SleeperCar2)
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