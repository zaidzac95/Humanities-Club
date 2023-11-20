using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
    
{
    public AudioSource BtnEnt;
    //public int a = 1;
    //public float Delay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMScene", 3f);
    }
    public void LoadMScene()
    {
        
        //Invoke("LoadMScene", Delay);
        //BtnEnt.Play();




       // SceneManager.LoadScene("Owl_s_Post_Office_demo");
            
        
        
    }

    public void LoadintroScene()
    {
        SceneManager.LoadScene("Main");
    }
    
}

