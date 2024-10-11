using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Juniper : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI QuestText1;
    public TextMeshProUGUI QuestText2;

    public Player PlayerScript;

    public bool Hiding;

    public GameObject JuniperHiding;
    public GameObject BananaHiding;

    public void OnTriggerEnter(Collider other)
    {
            DialogueBox.SetActive(true);
            Name.text = "Banana and Juniper";
            Dialogue.text = "Let's play hide and seek! Good luck finding us!";
        QuestText1.text = "Find me!";
        QuestText2.text = "Find me!";

        Hiding = true;
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
        if(Hiding == true)
        {
            JuniperHiding.SetActive(true);
            BananaHiding.SetActive(true);
            gameObject.SetActive(false);


        }
    }
}
