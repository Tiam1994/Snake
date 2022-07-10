using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthScore : MonoBehaviour
{
    private Text lengthText;
    private int lengthScore = 0;

    private void Start()
    {
        lengthText = GetComponent<Text>();
        lengthText.text = $"Length: {lengthScore}";
    }

    public void AddLengthScore()
    {
        lengthScore += 1;
        lengthText.text = $"Length: {lengthScore}";
    }
}
