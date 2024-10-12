using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerOffScreen : MonoBehaviour
{

    public void PowerOn()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
