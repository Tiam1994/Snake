using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private Score scoreBoard;

    private void Start()
    {
        scoreBoard = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            scoreBoard.AddScore();
            other.GetComponent<PlayerController>().AddTail();
            Destroy(gameObject);
        }
    }
}
