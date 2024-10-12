using UnityEngine;

public class MonkeyToy : MonoBehaviour
{
    public Player PlayerScript;

    public void OnTriggerEnter(Collider other)
    {
        PlayerScript.GotMonkey = true;
        gameObject.SetActive(false);
    }
}
