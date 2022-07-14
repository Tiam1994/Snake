using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    private Score scoreBoard;

    private void Start()
    {
        scoreBoard = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.tag == "Food")
            {
                scoreBoard.AddScore(5);
                other.GetComponent<PlayerController>().AddTail();
                Destroy(gameObject);
            }
            if(gameObject.tag == "SpeedUp")
            {
                scoreBoard.AddScore(10);
                other.GetComponent<PlayerController>().SpeedUp();
                Destroy(gameObject);
            }
            if(gameObject.tag == "SlowDown")
            {
                scoreBoard.AddScore(3);
                other.GetComponent<PlayerController>().SpeedDown();
                Destroy(gameObject);
            }
        }
    }
}
