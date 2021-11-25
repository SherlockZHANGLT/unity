using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBall : MonoBehaviour
{
    public shoot player;
    public int ball;
    public Text BallUI;
    void Start()
    {
        player.GetBall += Player_GetBall;
    }

    private void Player_GetBall(int ball)
    {
        Ball = ball;
    }
    void Update()
    {

    }
    public int Ball
    {
        get
        {
            return ball;
        }
        set
        {
            ball = value;
            BallUI.text = ball.ToString();
        }
    }

}
