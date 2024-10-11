using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public Player PlayerScript;

    public void OnTriggerEnter(Collider other)
    {
        PlayerScript.Gears++;
        gameObject.SetActive(false);
    }
}
