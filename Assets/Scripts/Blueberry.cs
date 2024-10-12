using UnityEngine;
using TMPro;

public class Blueberry : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;

    public TextMeshProUGUI Quest1Text;
    public TextMeshProUGUI Quest2Text;
    public Player PlayerScript;
    public GameObject Cookie;

    public void OnTriggerEnter(Collider other)
    {
        DialogueBox.SetActive(true);
        Name.text = "Grape";
        Dialogue.text = "Please, can you give Blueberry this cookie?";
        Quest1Text.text = "Give Blueberry a Cookie";
        Quest2Text.text = "Cookie?";
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
        Cookie.SetActive(false);
        PlayerScript.GotCookie = true;
    }
}
