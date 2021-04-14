using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleButton : MonoBehaviour
{
    public Image HTPlayImage;
    public Text BackText;
    // Start is called before the first frame update
    void Start()
    {
        HTPlayImage.enabled = false;
        BackText.enabled = false;
    }

    // Update is called once per frame
    public void LoadPlay()
    {
        SceneManager.LoadScene("Play");
    }
    public void HTPlay()
    {
        HTPlayImage.enabled = true;
        BackText.enabled = true;
    }
    public void Back()
    {
        HTPlayImage.enabled = false;
        BackText.enabled = false;
    }
    public void Exit()
    {
        Application.Quit();
        print("Exit");
    }
}
