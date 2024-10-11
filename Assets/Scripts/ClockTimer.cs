using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//ontheclock

public class ClockTimer : MonoBehaviour
{
    public Player PlayerScript;

    public bool timeractive;
    public float timer;

    public Image Clock;

    public Sprite Clock1;
    public Sprite Clock2;
    public Sprite Clock3;
    public Sprite Clock4;
    public Sprite Clock5;
    public Sprite Clock6;
    public Sprite Clock7;
    public Sprite Clock8;

    public int GearsCount;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Dialogue;
    public GameObject DialogueBox;


    public void GameStart()
    {
        timeractive = true;
    }

    public void FixedUpdate()
    {
        if (timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 5f)
        {
            Clock.sprite = Clock2;
        }

        if (timer > 10f)
        {
            Clock.sprite = Clock3;
        }

        if (timer > 15f)
        {
            Clock.sprite = Clock4;
        }

        if (timer > 20f)
        {
            Clock.sprite = Clock5;
        }

        if (timer > 25f)
        {
            Clock.sprite = Clock6;
        }

        if (timer > 30f)
        {
            Clock.sprite = Clock7;
        }

        if (timer > 35f)
        {
            Clock.sprite = Clock8;
        }

        if (timer > 40f)
        {
            Clock.sprite = Clock8;
        }

        if (timer > 50f)
        {
            PlayerScript.GameEnd();
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if(PlayerScript.Gears == 0)
        {
            DialogueBox.SetActive(true);
            Name.text = "Player";
            Dialogue.text = "I have no gears to deposit.";
        }
        if(PlayerScript.Gears > 1 || PlayerScript.Gears == 1)
        {
            DialogueBox.SetActive(true);
            Name.text = "Player";
            Dialogue.text = "I have deposited " + PlayerScript.Gears + " Gears. This will grant me more time.";
            GearsCount = PlayerScript.Gears;
            int Removal = GearsCount * 9;
            timer = timer - Removal;
            PlayerScript.Gears = 0;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        DialogueBox.SetActive(false);
    }


}
