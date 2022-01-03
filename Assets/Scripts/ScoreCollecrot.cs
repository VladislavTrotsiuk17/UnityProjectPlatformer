using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollecrot : MonoBehaviour
{
    private static int score;
    [SerializeField] private Text textScore;

    private void Start()
    {
        score = 0;
    }
    public static void AddScore(int value)
    {
        score += value;
        Debug.Log(score);
    }

    
    //private static void ShowValue(int score)
    //{
    //    textScore.text = "Score:" + score.ToString();
    //}
}
