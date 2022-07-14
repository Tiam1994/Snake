using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int allScore = 0;
    private Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = $"Score: {allScore}";
    }

    public void AddScore(int score)
    {
        allScore += score;
        scoreText.text = $"Score: {allScore}";
    }
}
