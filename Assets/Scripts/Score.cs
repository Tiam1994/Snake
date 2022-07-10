using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    private int scorePerEat = 5;
    private Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = $"Score: {score}";
    }

    public void AddScore()
    {
        score += scorePerEat;
        scoreText.text = $"Score: {score}";
    }
}
