using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO ENSURE THAT THE GUI CAN TRAVEL BETWEEN SCENES WITHOUT DUPLICATING - APPLY THIS SCRIPT TO THE CANVAS GAMEOBJECT

public class GUISingleton : MonoBehaviour
{
    static GUISingleton instance;

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
