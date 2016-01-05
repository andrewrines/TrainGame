using UnityEngine;
using System.Collections;

// THE PURPOSE OF THIS SCRIPT IS TO HANDLE PLAYER MOVEMENT - APPLY THIS SCRIPT TO THE PLAYER

public class PlayerMovement : MonoBehaviour
{
    float Speed = 3;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right * Time.deltaTime * Speed);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * Time.deltaTime * Speed);
    }
}