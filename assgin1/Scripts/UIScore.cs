using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScore : MonoBehaviour
{
    public shoot player;
    public int score;
    public Text ScoreUI;
    void Awake()
    {
        player.GetScore += Player_GetScore;
    }

    private void Player_GetScore(int score)
    {
        Score = score;
    }
    void Update()
    {
        
    }
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreUI.text = score.ToString();
        }
    }

}