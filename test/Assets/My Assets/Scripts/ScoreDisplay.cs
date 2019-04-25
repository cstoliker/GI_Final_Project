using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text display;
    private int score;

    private void Awake()
    {
        display = GetComponent<Text>();
        score = PlayerManager.instance.calculator.getScore();
        DisplayScore();
    }

    public void DisplayScore()
    {
        display.text = "You killed " + score.ToString() + " businessmen, I hope you feel good about that";
    }

}
