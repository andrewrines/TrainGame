using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// THE PURPOSE OF THIS SCRIPT IS DIALOGUE WITH HECTOR - APPLY THIS TO HECTOR

public class Hector : MonoBehaviour
{
    Text hectorText;

    void Awake()
    {
        hectorText = GameObject.FindGameObjectWithTag("GUI").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(talk());
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            hectorText.text = "";
        }
    }

    IEnumerator talk()
    {
        hectorText.text = "hey how's it goin'";
        yield return new WaitForSeconds(1);
        hectorText.text = "";
    }
}
