using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// THE PURPOSE OF THIS SCRIPT IS DIALOGUE WITH CLIFFORD RAWLINS AND HIS FIANCEE - APPLY THIS TO CLIFFORD OR CLIFFORD'S DOOR

public class Clifford : MonoBehaviour
{
    Text cliff;
    Text choice1;
    Text choice2;
    Text choice3;

    void Awake()
    {
        cliff = GameObject.FindGameObjectWithTag("GUI").GetComponent<Text>();
        choice1 = GameObject.FindGameObjectWithTag("Choice1GUI").GetComponent<Text>();
        choice2 = GameObject.FindGameObjectWithTag("Choice2GUI").GetComponent<Text>();
        choice3 = GameObject.FindGameObjectWithTag("Choice3GUI").GetComponent<Text>();
    }

    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Player" && Input.GetKeyDown(KeyCode.Return) && Inventory.water == false)
        {
            // this is all fucked up because coroutines all play at the same time - they execute in order, but they don't wait for the last one to stop for the next one to begin
            cliff.text = ("Who's there?");
            StartCoroutine(openDoor());
            StartCoroutine(mediumWait("Eleanor, it's the porter girl!"));
            StartCoroutine(longWait("Hello there, young lady. What's the news? Just checking in?"));
            StartCoroutine(extraLongWait("THIRST WATER GET THIRST THIRST"));
            StartCoroutine(closeDoor(6.5f));
        }

        if (c.tag == "Player" && Input.GetKeyDown(KeyCode.Return) && Inventory.water == true)
        {
            StartCoroutine(openDoor());
            StartCoroutine(shortWait("SMOKEWEED"));
            StartCoroutine(herb());
        }
    }

    IEnumerator openDoor()
    {
        yield return new WaitForSeconds(1.5f);
        GetComponent<Renderer>().enabled = true;
    }

    IEnumerator closeDoor(float waitTime)
    {
        yield return new WaitForSeconds(6.5f);
        GetComponent<Renderer>().enabled = false;
        cliff.text = "";
    }

    IEnumerator veryShortWait(string dialogue)
    {
        yield return new WaitForSeconds(.7f);
        cliff.text = (dialogue);
    }

    IEnumerator shortWait(string dialogue)
    {
        yield return new WaitForSeconds(1);
        cliff.text = (dialogue);
    }

    IEnumerator mediumWait(string dialogue)
    {
        yield return new WaitForSeconds(2);
        cliff.text = (dialogue);
    }

    IEnumerator longWait(string dialogue)
    {
        yield return new WaitForSeconds(3.5f);
        cliff.text = (dialogue);
    }

    IEnumerator extraLongWait(string dialogue)
    {
        yield return new WaitForSeconds(5.5f);
        cliff.text = (dialogue);
    }



    IEnumerator herb()
    {
        yield return new WaitForSeconds(3);
        choice1.text = "weed";
        choice2.text = "marijuana";
        choice3.text = "a bug";
    }
}
