using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Grape : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI QuestText1;
    public TextMeshProUGUI QuestText2;
    public Player PlayerScript;

    public GameObject Cookie;
    public void OnTriggerEnter(Collider other)
    {
        if(PlayerScript.GotCookie)
        {
            DialogueBox.SetActive(true);
            Name.text = "Blueberry";
            Dialogue.text = "Thank you!!";
            QuestText1.text = "Complete!";
            QuestText2.text = "Complete!";
            PlayerScript.Gears++;
            PlayerScript.QuestsCompleted++;
            PlayerScript.QuestsCompleted++;
            Cookie.SetActive(true);
            PlayerScript.GotCookie = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
    }
}
