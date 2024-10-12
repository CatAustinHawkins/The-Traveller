using UnityEngine;

public class QuestMenu : MonoBehaviour
{

    public float timer;
    public bool timeractive;

    public bool isquestmenuopen;

    public GameObject QuestUI;


    // Update is called once per frame
    void Update()
    {
        if(timeractive)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 0.5f)
        {
            timeractive = false;
            timer = 0;
        }
    }

    public void QuestButton()
    {
        if(timeractive == false && isquestmenuopen == false)
        {
            QuestUI.SetActive(true);
            isquestmenuopen = true;
            timeractive = true;
        }

        if (timeractive == false && isquestmenuopen == true)
        {
            QuestUI.SetActive(false);
            isquestmenuopen = false;
            timeractive = true;
        }
    }
}
