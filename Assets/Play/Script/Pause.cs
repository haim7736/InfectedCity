using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    bool IsPause;
    public Image PauseImage;
    public Image Quit;
    // Start is called before the first frame update
    void Start()
    {
        IsPause = false;
        PauseImage.enabled = false;
      
        Quit.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPause == false)
            {
                Time.timeScale = 0;
                IsPause = true;
                PauseImage.enabled = true;
        
                Quit.enabled = true;
                return;
            }
            else if(IsPause == true)
            {
                Time.timeScale = 1;
                IsPause = false;
                PauseImage.enabled = false;
               
                Quit.enabled = false;
            }
        }
    }
}
