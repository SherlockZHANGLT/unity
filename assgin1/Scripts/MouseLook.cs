using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 } //定义一个枚举，移动xy，或者只是移动x，或者y
    public RotationAxes axes = RotationAxes.MouseXAndY;                 //声明一个枚举变量，方便在外面修改移动模式
    public float sensitivityX = 5f;                                    //定义一个移动速度
    public float sensitivityY = 5f;

    public float minimumY = -60f;       //定义俯视最低值，建议这个值，要不然会转过头
    public float maximumY = 60f;        //定义俯视最高值，建议这个值，要不然会转过头

    float rotationY = 0f;               //存储实际转动的Y值

    void Start()
    {

    }
    void Update ()
    {   //根据用户不同旋转方式来进行相对应的视角变换
        switch (axes)               
        {
            case RotationAxes.MouseXAndY:
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX; 

                rotationY += Input.GetAxis("Mouse Y") * sensitivityY; //
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
                break;
            case RotationAxes.MouseX:
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
                break;
            case RotationAxes.MouseY:
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
                break;
            default:
                break;
        }
    }
}
