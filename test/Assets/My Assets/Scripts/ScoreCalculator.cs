using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    private int score;
    private Text display;
    private string displayText;

    private void Start()
    {
        display = GetComponent<Text>();
        score = 0;
    }
    public void AddPoint()
    {
        score += 1;
        Debug.Log(score);
    }

    public int getScore()
    {
        return score;
    }
}
