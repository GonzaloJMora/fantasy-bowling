using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public int score = 0; 
    public Text score_txt;

    public void Add(int pins)
    {
        score+=pins;
        UpdateScore();
    }
    void start()
    {
        score = 0;
    }
    void UpdateScore()
    {
        score_txt.text = "Score = "+score;
    }
}