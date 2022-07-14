using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void ContinueButton()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
