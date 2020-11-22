using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private int Score;
    [SerializeField] private int ScoreMultiplier = 1;
    [SerializeField] private string LastTagName;
    [SerializeField] private TextMeshProUGUI GetScoreText;
    [SerializeField] private TextMeshProUGUI GetComboText;
    [SerializeField] private TextMeshProUGUI GetLastText;

    private void Start()
    {
        AddToText(0);
        AddToCombo(1);
    }


    public void AddScore()
    {
        Score += 10 * ScoreMultiplier;
        AddToText(Score);
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
        AddToCombo(ScoreMultiplier);
        LastTagName = TagName;
        AddToLast(LastTagName);
    }
    private void AddToText(int score)
    {
        GetScoreText.text = $"Score: {score}";
    }
    private void AddToCombo(int Combo)
    {
        GetComboText.text = $"Combo: {Combo}";
    }
    private void AddToLast(string Text)
    {
        GetLastText.text = $"Last Destroyed: {Text}";
    }
}
