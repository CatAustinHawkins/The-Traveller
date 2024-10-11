using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Strawberry : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI QuestText;

    public Player PlayerScript;

    public bool QuestComplete;

    public void OnTriggerEnter(Collider other)
    {
        if(PlayerScript.GotFish1 && PlayerScript.GotFish2 && PlayerScript.GotFish3)
        {
            DialogueBox.SetActive(true);
            Name.text = "Strawberry";
            Dialogue.text = "Thank you for catching all the fish! Here, have this gear I found as a reward.";
            QuestText.text = "Complete!";
            PlayerScript.Gears++;
            PlayerScript.GotFish1 = false;
            PlayerScript.GotFish2 = false;
            PlayerScript.GotFish3 = false;
            QuestComplete = true;
            PlayerScript.QuestsCompleted++;
        }
        
        if(QuestComplete == false)
        {
            DialogueBox.SetActive(true);
            Name.text = "Strawberry";
            Dialogue.text = "Can you please collect 3 different fish for me? Heres a fishing rod!";
            PlayerScript.GotFishingRod = true;
            QuestText.text = "Collect 1 of each Fish";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
    }
}
