using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public int score = 0; 
    public GameObject score_txt;

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
        score_txt.GetComponent<Text>().text = "Score = "+score;
    }
}