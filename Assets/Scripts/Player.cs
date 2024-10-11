using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script

    public int Gears;

    public bool GotFish1;
    public bool GotFish2;
    public bool GotFish3;

    public bool GotFishingRod;

    public bool GotMonkey;

    public bool GotCookie;

    public bool FoundJuniper;
    public bool FoundBanana;

    public int QuestsCompleted;

    public TextMeshProUGUI GearCount;

    public GameObject GameEndMenu;

    public TextMeshProUGUI EndMenuText;

    public float timer;
    public bool timeractive;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //rb equals the rigidbody on the player
    }


    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1

        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 

        GearCount.text = Gears.ToString();

        if (QuestsCompleted > 6)
        {
            timeractive = true;
        }

        if (timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if (timer > 1f)
        {
            GameEnd();
        }
    }


    public void GameEnd()
    {
        GameEndMenu.SetActive(true);
        EndMenuText.text = "You helped " + QuestsCompleted + "residents.";
    }
}
