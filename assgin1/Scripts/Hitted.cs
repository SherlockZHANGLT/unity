using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitted : MonoBehaviour
{
    public AudioClip _HitClip;
    AudioSource m_HitAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_HitAudioSource = gameObject.AddComponent<AudioSource>();
        m_HitAudioSource.clip = _HitClip;
    }
    void OnCollisionEnter(Collision collision)
    {  
        // m_HitAudioSource.Play ();
        if (collision.gameObject.name.Contains("Cube")) {//碰撞到方块
            m_HitAudioSource.Play ();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
