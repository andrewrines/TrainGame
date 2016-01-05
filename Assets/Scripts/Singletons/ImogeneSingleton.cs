using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO ENSURE THAT THE PLAYER CAN TRAVEL BETWEEN SCENES WITHOUT DUPLICATING - APPLY THIS SCRIPT TO THE PLAYER

public class ImogeneSingleton : MonoBehaviour
{
    static ImogeneSingleton instance;

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
