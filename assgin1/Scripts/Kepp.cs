using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kepp : MonoBehaviour
{
    public static int u=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake() { DontDestroyOnLoad(gameObject); }
}
