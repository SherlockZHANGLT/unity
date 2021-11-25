using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayUI : MonoBehaviour
{
    public RectTransform UI;//准星
    private RaycastHit hit;
    private Ray ray;
    public LayerMask layer;//遮罩层
    void Start()
    {

    }
    void Update()
    {
        //返回一条射线从摄像机通过一个屏幕点（鼠标落于屏幕的点）
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50, layer.value))
        {

            UI.gameObject.SetActive(true);
            UI.position = Input.mousePosition;

        }
        else
            UI.gameObject.SetActive(false);
    }
}
