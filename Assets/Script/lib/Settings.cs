using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public static Settings instance;

    void Awake()
    {
        instance = this;
    }


    public void GetResolution()
    {
        if(PlayerPrefs.HasKey("width") && PlayerPrefs.HasKey("height"))
        {
            Screen.SetResolution(PlayerPrefs.GetInt("width"), PlayerPrefs.GetInt("height"), true);
        }else
        {
            // Default resolution
            Screen.SetResolution(1200, 1920, true);
        }
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
