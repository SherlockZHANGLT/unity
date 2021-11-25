using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    public AudioClip _AudioClip;
    
    AudioSource m_AudioSource;
    void Start()
    {
        m_AudioSource= gameObject.AddComponent<AudioSource>();
        m_AudioSource.clip = _AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.y < 0)
        {
            SceneManager.LoadScene(8);
        }
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        if ((Input.GetAxis("Horizontal")!=0||Input.GetAxis("Vertical")!=0) && !m_AudioSource.isPlaying)
        {
            m_AudioSource.Play();
        }
        else if (Input.GetAxis("Horizontal")==0 && Input.GetAxis("Vertical")==0)
        {
            m_AudioSource.Stop();
        }
        transform.Translate(-h,0,-v);
    }
}
