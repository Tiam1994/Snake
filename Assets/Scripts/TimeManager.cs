using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeManager : MonoBehaviour
{
    private Text clock;
    private float timer = 0.0f;
    private int hours, minutes, seconds;

    private void Start()
    {
        clock = GetComponent<Text>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Clock();
    }

    private void Clock()
    {
        hours = Mathf.FloorToInt(timer / 3600.0f);
        minutes = Mathf.FloorToInt(timer / 60.0f);
        seconds = Mathf.FloorToInt(timer - minutes * 60);
        clock.text = $"{hours}:{minutes}:{seconds}";
    }
}
