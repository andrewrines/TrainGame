using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO ENSURE THAT THE EVENTSYSTEM (whatever it does) CAN TRAVEL BETWEEN SCENES WITHOUT DUPLICATING - APPLY THIS SCRIPT TO THE EVENTSYSTEM GAMEOBJECT

public class EventSystemSingleton : MonoBehaviour
{
    static EventSystemSingleton instance;

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
