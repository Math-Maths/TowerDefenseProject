using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreControl
{
    private static int score;
    
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            {
            if (score < 0)
                score = 0;
            }
            if (score > HighScore)
            {
                HighScore = score;
            }
            //Debug.Log("Pontuação atualizada para:" + Score);
        }
    }

    public static int HighScore
    {
        get
        {
            int highScore = PlayerPrefs.GetInt("highScore", 0);
            return highScore;
        }
        set
        {
            if (value > HighScore)
            {
                PlayerPrefs.SetInt("highScore", value);
            }
        }
    }
}
