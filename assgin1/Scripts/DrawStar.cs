using UnityEngine;
using System.Collections;
 
public class DrawStar : MonoBehaviour {
    public Texture2D texture;

    // Use this for initialization
    void OnGUI()
    {
        int width = 50;//准星宽度
        int height = 50;//准星高度
        Rect rect = new Rect(Screen.width/2 - width/2,Screen.height/2 - width/2, width, height);//准星位置
 
        GUI.DrawTexture(rect, texture);
    }
}