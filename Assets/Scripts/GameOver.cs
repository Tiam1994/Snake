using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;

    public void GameOverPanel()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
