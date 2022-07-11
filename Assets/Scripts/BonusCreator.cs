using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCreator : MonoBehaviour
{
    public GameObject speedUpBonus;
    public GameObject speedDownBonus;
    public GameObject foodBonus;

    private float positionX = 14f;
    private float positionZ = 7.5f;

    private void Start()
    {
        StartCoroutine(AddSpeedUpBonuse());
        StartCoroutine(AddFoodBonus());
        StartCoroutine(AddSpeedDownBonuse());
    }

    IEnumerator AddFoodBonus()
    {
        while(true)
        {
            yield return new WaitForSeconds(4f);
            Instantiate(foodBonus, GetNewPosition(), Quaternion.identity);
        }
    }

    IEnumerator AddSpeedUpBonuse()
    {
        while(true)
        {
            yield return new WaitForSeconds(10f);
            Instantiate(speedUpBonus, GetNewPosition(), Quaternion.identity);
        }
    }

    IEnumerator AddSpeedDownBonuse()
    {
        while(true)
        {
            yield return new WaitForSeconds(12f);
            Instantiate(speedDownBonus, GetNewPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetNewPosition()
    {
        return new Vector3(Random.Range(-positionX, positionX), 0, Random.Range(-positionZ, positionZ));
    }
}
