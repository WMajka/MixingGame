using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private int Score;
    [SerializeField] private int ScoreMultiplier = 1;
    [SerializeField] private string LastTagName;


    private void Update()
    {
        Debug.Log(Score);
        Debug.Log(ScoreMultiplier);
    }

    public void AddScore()
    {
        Score += 10 * ScoreMultiplier;
    }
    public void AddMultiplier(string TagName)
    {
        if (TagName == LastTagName)
        {
            Debug.Log("Added to mult");
            ScoreMultiplier += 1;
        }
        else
        {
            Debug.Log("reset to one");
            ScoreMultiplier = 1;
        }
        LastTagName = TagName;
    }
}
