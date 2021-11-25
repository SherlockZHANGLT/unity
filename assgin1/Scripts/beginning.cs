using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginning : MonoBehaviour
{
    public int i;
    public void OnLoginButtonClick()
    {
        Invoke("LS", 1f);     
    }
    // Start is called before the first frame update
    
    public void LS()
    {
        SceneManager.LoadScene(i);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
