using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    private GameOver gameOver;

    private void Start()
    {
        gameOver = FindObjectOfType<GameOver>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameOver.GameOverPanel();
        }
    }
}
