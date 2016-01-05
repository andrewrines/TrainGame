using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour
{
    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(gameObject);
            Inventory.water = true;
        }
    }
}
