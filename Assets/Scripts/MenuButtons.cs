using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject AboutMenu;
    public GameObject ControlsMenu;
    public GameObject TopScreen;
    public GameObject QuestButton;

    public ClockTimer ClockScript;

    public void StartGameButton()
    {
        TopScreen.SetActive(true);
        MainMenu.SetActive(false);
        QuestButton.SetActive(true);
        ClockScript.GameStart();
    }

    public void AboutMenuButton()
    {
        AboutMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void ControlsMenuButton()
    {
        ControlsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void BackToMainButton()
    {
        AboutMenu.SetActive(false);
        ControlsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void PowerOffButton()
    {
        SceneManager.LoadScene("PowerOff");
    }
}
