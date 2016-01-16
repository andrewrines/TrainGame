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

        // I don't like that a separate GUI is used for each choice
        choice1 = GameObject.FindGameObjectWithTag("Choice1GUI").GetComponent<Text>();
        choice2 = GameObject.FindGameObjectWithTag("Choice2GUI").GetComponent<Text>();
        choice3 = GameObject.FindGameObjectWithTag("Choice3GUI").GetComponent<Text>();
    }

    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Player" && Input.GetKeyDown(KeyCode.Return) && Inventory.water == false)
        {
            StartCoroutine(FirstConversation());
        }

        if (c.tag == "Player" && Input.GetKeyDown(KeyCode.Return) && Inventory.water == true)
        {
            StartCoroutine(BroughtWater());
        }
    }

    IEnumerator FirstConversation()
    {
        cliff.text = "Who's there?";
        yield return new WaitForSeconds(1);
        cliff.text = "";
        yield return new WaitForSeconds(.5f);
        GetComponent<Renderer>().enabled = true;
        cliff.text = "Eleanor, it's the porter girl!";
        yield return new WaitForSeconds(2);
        cliff.text = "Hello there, young lady. What's the news? Just checking in?";
        yield return new WaitForSeconds(2.5f);
        cliff.text = "THIRST WATER GET THIRST THIRST";
        yield return new WaitForSeconds(1.5f);
        GetComponent<Renderer>().enabled = false;
        cliff.text = "";
    }

    IEnumerator BroughtWater()
    {
        GetComponent<Renderer>().enabled = true;
        cliff.text = "SMOKEWEED";
        yield return new WaitForSeconds(1);
        choice1.text = "weed";
        choice2.text = "marijuana";
        choice3.text = "a bug";
    }
}
