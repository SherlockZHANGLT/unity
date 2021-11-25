using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    //Bullet不在camera视角范围内时自动销毁
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
