using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// THE PURPOSE OF THIS SCRIPT IS TO INSTANTIATE A NEWSPAPER IF THE CLUE "MED1" IS PRESENT IN THE GAME - APPLY THIS SCRIPT TO THE NEWSPAPER GAMEOBJECT

public class Newspaper : MonoBehaviour
{
    void Awake()
    {
        if (!RandomClues.used.Contains("med1"))
        {
            Destroy(gameObject);
        }
    }
}
