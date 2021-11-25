using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class B2 : MonoBehaviour
{
    public int i;
    public void OnLoginButtonClick()
    {
        Invoke("LS", 1f);   
    }    
    public void LS()
    {
        SceneManager.LoadScene(i);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
