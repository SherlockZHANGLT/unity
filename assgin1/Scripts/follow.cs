using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform m;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - m.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + m.position;
    }
}
