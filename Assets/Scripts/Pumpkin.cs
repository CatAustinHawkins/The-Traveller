using UnityEngine;
using TMPro;

public class Pumpkin : MonoBehaviour
{

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI QuestText;

    public Player PlayerScript;

    public bool QuestComplete;

    public GameObject ToyMonkey1;
    public GameObject ToyMonkey2;

    public void OnTriggerEnter(Collider other)
    {
        if (PlayerScript.GotMonkey)
        {
            DialogueBox.SetActive(true);
            Name.text = "Pumpkin";
            Dialogue.text = "Thank you for finding my monkey!!";
            QuestText.text = "Complete!";
            PlayerScript.Gears++;
            PlayerScript.GotMonkey = false;
            QuestComplete = true;
            PlayerScript.QuestsCompleted++;
            ToyMonkey2.SetActive(true);
        }

        if (QuestComplete == false)
        {
            DialogueBox.SetActive(true);
            Name.text = "Pumpkin";
            Dialogue.text = "Can you please please please find my monkey toy? I lost him in the forest!";
            QuestText.text = "Find Toy Monkey";
            ToyMonkey1.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
    }
}
