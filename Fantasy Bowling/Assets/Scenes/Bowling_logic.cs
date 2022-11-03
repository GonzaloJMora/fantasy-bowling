using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bowling_logic : MonoBehaviour
{
    public Transform pin;
    public float max = .6f; // can be changed with UI
    public int points = 1; 
    public Score score; //score object from score.cs


    void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void FellOrNot()
    {
        try
        {
            if(pin.up.y < max)
            {
                score.Add(points);
                gameObject.GetComponent<Collider>().enabled = false;
            }
        }
        catch
        {
            Debug.Log("Pins are not working properly, it might be in a dead zone");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        FellOrNot();
    }
   
}
