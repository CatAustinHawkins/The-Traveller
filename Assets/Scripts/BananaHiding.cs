using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BananaHiding : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI QuestText;

    public Player PlayerScript;

    public GameObject JuniperFound;
    public GameObject BananaFound;

    public void OnTriggerEnter(Collider other)
    {
        DialogueBox.SetActive(true);
        Name.text = "Banana";
        Dialogue.text = "You found me!";
        QuestText.text = "Complete!";
        PlayerScript.QuestsCompleted++;
    }

    private void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
        gameObject.SetActive(false);
        BananaFound.SetActive(true);
        PlayerScript.Gears++;
    }
}
