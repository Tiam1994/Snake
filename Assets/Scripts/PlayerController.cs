using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject newTail;
    public float speed;
    public List<GameObject> snakeTail = new List<GameObject>();
    public ParticleSystem bonusEffect;
    public AudioSource bonusSound;
    private LengthScore lengthBoard;

    private void Start()
    {
        snakeTail.Add(gameObject);
        lengthBoard = FindObjectOfType<LengthScore>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
    }

    public void AddTail()
    {
        lengthBoard.AddLengthScore();

        Vector3 newTailPos = snakeTail[snakeTail.Count - 1].transform.position;

        snakeTail.Add(Instantiate(newTail, newTailPos, Quaternion.identity));
    }

    public void SpeedUp()
    {
        speed += 0.5f;
    }

    public void SpeedDown()
    {
        speed -= 0.5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Food") || other.CompareTag("SpeedUp") || other.CompareTag("SlowDown"))
        {
            bonusEffect.Play();
            bonusSound.Play();
        }
    }
}
