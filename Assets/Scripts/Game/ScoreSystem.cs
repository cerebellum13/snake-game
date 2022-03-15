using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int currentScore = 100;
    public GameObject scoreValueText;

    public void Start()
    {
        scoreValueText.GetComponent<Text>().text = currentScore.ToString();
    }
    public void increaseScore()
    {
        currentScore += 1;
        scoreValueText.GetComponent<Text>().text = currentScore.ToString();
    }
}
