using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int currentScore = 0;
    public GameObject scoreValueText;

    private void Update()
    {
        scoreValueText.GetComponent<Text>().text = currentScore.ToString();
    }
    public static void increaseScore()
    {
        currentScore += 1;
    }
}
