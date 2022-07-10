using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreation : MonoBehaviour
{
    public GameObject food;
    private GameObject newFood;
    private float positionX = 8f;
    private float positionZ = 8f;

    private void Update()
    {
        if(!newFood)
        {
            AddFood();
        }
    }

    private void AddFood()
    {
        newFood = Instantiate(food, NewPosition(), Quaternion.identity);
    }

    private Vector3 NewPosition()
    {
        return new Vector3(Random.Range(-positionX, positionX), 0, Random.Range(-positionZ, positionZ));
    }
}
