using UnityEngine;
using System.Collections;

//this script is on the FishingRod
public class Fishing : MonoBehaviour
{
    [Header("int")]
    public int random; //int to store the value of Random.Range

    [Header("bools")]
    public bool canfish; //bool for if the player can fish or not

    [Header("GameObjects")]
    public GameObject FishIndicator1; //Fish Image - to show the player a fish has spawned
    public GameObject FishIndicator2;
    public GameObject FishIndicator3;

    public Player PlayerScript;

    public bool timeractive;
    public float timer;

    public void FixedUpdate()
    {
        if (canfish && PlayerScript.GotFishingRod) //if the player can fish
        {
            if (Input.GetKey(KeyCode.F)) //When the player presses F
            {
                FishIndicator1.SetActive(false); //hide the fish indicator
                FishIndicator2.SetActive(false); //hide the fish indicator
                FishIndicator3.SetActive(false); //hide the fish indicator
                Fished();//call the Fished function
                canfish = false;
            }
        }

        if(timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 2)
        {
            random = Random.Range(0, 4); //set random to random value between 0 and 10
            if (random == 1)
            {
                FishIndicator1.SetActive(true); //enable the fish indicator - telling the player theres a fish they can catch

            }
            if (random == 2)
            {
                FishIndicator2.SetActive(true); //enable the fish indicator - telling the player theres a fish they can catch

            }
            if(random == 3)
            {
                FishIndicator3.SetActive(true); //enable the fish indicator - telling the player theres a fish they can catch
            }
            canfish = true; //set canfish to true

            timer = 0;
        }
    }

    public void OnTriggerEnter(Collider other) //when the player enters the collider of the fishing rod
    {
        if(PlayerScript.GotFishingRod)
        {
            timeractive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        timeractive = false;
        timer = 0;
        //when the player exits the fishing rods trigger, hide the fishing indicator UI, stop the corotine, and stop audio
    }


    public void Fished()
    {
        if (random == 1)
        {
            PlayerScript.GotFish1 = true;
        }
        if (random == 2)
        {
            PlayerScript.GotFish2 = true;

        }
        if (random == 3)
        {
            PlayerScript.GotFish3 = true;
        }
    }

}