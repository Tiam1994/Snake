using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreation : MonoBehaviour
{
    public GameObject food;
    private GameObject newFood;
    private float positionX = 8f;
    private float positionZ = 8f;
    private float foodCreationTimer;

    private void Update()
    {
        foodCreationTimer += Time.deltaTime;
        AddFood();
    }

    private void AddFood()
    {
        if(foodCreationTimer >= 4f)
        {
            newFood = Instantiate(food, NewPosition(), Quaternion.identity);
            foodCreationTimer = 0;
        }
    }

    private Vector3 NewPosition()
    {
        return new Vector3(Random.Range(-positionX, positionX), 0, Random.Range(-positionZ, positionZ));
    }
}
