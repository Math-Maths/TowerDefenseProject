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
            if (score < 0){
                score = 0;
            }
            //Debug.Log("Pontuação atualizada para:" + Score);
        }
    }
}
