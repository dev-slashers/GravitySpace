using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingUiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonMain()
    {
        SceneManager.LoadScene("Main");   
    }


    void StoreResolution(int width, int height)
    {
        PlayerPrefs.SetInt("width", width);
        PlayerPrefs.SetInt("height", height);
        Screen.SetResolution(width, height, true);
    }

    public void ButtonSmall()
    {
        StoreResolution(480, 800);

    }

    public void ButtonMiddle()
    {
        StoreResolution(1080, 1920);
    }

    public void ButtonLarge()
    {
        StoreResolution(1200, 1920);
    }

}
