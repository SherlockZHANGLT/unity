using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int i;
    void Start()
    {
        
    }
    void Update()//在Update()中添加Player的移动控制
    {
        if (this.transform.localPosition.y < -0)
        {
            SceneManager.LoadScene(i);
        }
    }
}