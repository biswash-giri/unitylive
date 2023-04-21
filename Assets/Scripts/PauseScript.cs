using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;


    public void pauseClick()
    {
        if(gamePaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void menuClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale= 0f;
        gamePaused= true;
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void quitClick()
    {
        Application.Quit();
    }
}
