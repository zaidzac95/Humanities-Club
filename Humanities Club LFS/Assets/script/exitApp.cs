using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class exitApp : MonoBehaviour
{
    // Start is called before the first frame update
    
    
        //public AudioSource BtnExt;

        public void BtnExtClk()
        {
           // BtnExt.Play();
            SceneManager.LoadScene("Main");
        }
  }

