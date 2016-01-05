using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO ENSURE THAT THE GAMEMANAGER CAN TRAVEL BETWEEN SCENES WITHOUT DUPLICATING - APPLY THIS SCRIPT TO THE GAMEMANAGER GAMEOBJECT

public class GameManagerSingleton : MonoBehaviour
{
    static GameManagerSingleton instance;

    void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
