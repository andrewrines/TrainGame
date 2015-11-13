using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-transform.right * Time.deltaTime * speed);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(transform.right * Time.deltaTime * speed);
    }
}
