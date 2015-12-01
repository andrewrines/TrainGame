using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right * Time.deltaTime * Speed);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * Time.deltaTime * Speed);
    }
}