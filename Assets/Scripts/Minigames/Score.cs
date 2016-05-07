using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static Score score;
    public Text score_text;

    string pre_score = "Score: ";
    public int score_number;

    public int goal;
    bool victory = false;
    public Text goal_text;

    void Awake ()
    {
        score = this;

        UpdateScore(0);
    }


    public void UpdateScore(int amount)
    {
        score_number += amount;

        score_text.text = pre_score + score_number;

        if (score_number >= goal && !victory)
        {
            victory = true;
            StartCoroutine(Victory());
        }
    }

    public IEnumerator Victory()
    {
        goal_text.gameObject.SetActive(true);

        yield return new WaitForSeconds(4.0f);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Finale");
    }


    void Update ()
    {
	
	}
}
