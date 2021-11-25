﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscQuit : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void Quit()
    {
        //打包时不能使用
        //UnityEditor.EditorApplication.isPlaying = false;
        //测试时不能执行，打包后可以执行
        Application.Quit();
    }
}
