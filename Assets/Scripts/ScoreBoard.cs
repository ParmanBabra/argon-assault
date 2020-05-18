using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int score;
    int textScore;
    float time;
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    void Update()
    {
        if (textScore > score)
            return;

        if (time < 1f)
            time += Time.deltaTime;

        scoreText.text = textScore.ToString();
        textScore++;
        time = 0;
    }


    public void ScoreHit(int scorePoint)
    {
        score += scorePoint;
    }
}
