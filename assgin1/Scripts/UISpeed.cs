using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISpeed : MonoBehaviour
{
    public shoot player;
    public float speed;
    public Text SpeedUI;
    void Start()
    {
        player.GetSpeed += Player_GetSpeed;
    }

    private void Player_GetSpeed(float speed)
    {
        Speed = speed;
    }
    void Update()
    {
        
    }
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
            SpeedUI.text = speed.ToString();
        }
    }

}
