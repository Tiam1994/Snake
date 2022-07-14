using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailBehavior : MonoBehaviour
{
    private Vector3 tailTarget;
    private GameObject nextTailObj;
    private PlayerController snake;
    private float speedTail;
    private int index;
    private GameOver gameOver;

    private void Start()
    {
        snake = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        speedTail = snake.speed;
        nextTailObj = snake.snakeTail[snake.snakeTail.Count - 2];
        index = snake.snakeTail.IndexOf(gameObject);

        gameOver = FindObjectOfType<GameOver>();
    }

    private void Update()
    {
        tailTarget = nextTailObj.transform.position;
        gameObject.transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speedTail);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (index > 1)
            {
                gameOver.GameOverPanel();
            }
        }
    }
}
