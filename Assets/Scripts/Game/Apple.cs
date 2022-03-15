using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    float minPosition = -23.5f;
    float maxPosition = 23.5f;
    float stepSize = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreSystem.increaseScore();
        // Snake.GetInstance().AddSnakeTale();
        gameObject.transform.position = generateNewPosition();
    }

    private Vector3 generateNewPosition()
    {
        return new Vector3(GetRandomPositionPoint(), GetRandomPositionPoint());
    }

    private float GetRandomPositionPoint()
    {
        float randomPosition = Random.Range(minPosition, maxPosition);
        float numSteps = Mathf.Floor(randomPosition / stepSize);
        float adjustedPosition = numSteps * stepSize;

        return adjustedPosition;
    }
}
