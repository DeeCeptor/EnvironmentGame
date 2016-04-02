using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static Score score;
    public Text score_text;

    string pre_score = "Score: ";
    public int score_number;

    void Awake ()
    {
        score = this;

        UpdateScore(0);
    }


    public void UpdateScore(int amount)
    {
        score_number += amount;

        score_text.text = pre_score + score_number;
    }


    void Update ()
    {
	
	}
}
