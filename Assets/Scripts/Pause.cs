using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject pauseButton;
    public GameObject pausedPanel;
    public GameObject quitButton;
    public GameObject resumeButton;

    public void PauseGame ()
    {
        Time.timeScale = 0f;
        pausedPanel.SetActive(true);
    }

    public void ResumeButton ()
    {
        Time.timeScale = 1f;
        pausedPanel.SetActive(false);
    }

    public void Quit(string MenuScene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(MenuScene);
    }
}
