using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManagerLevel1Controller : MonoBehaviour
{
  

    public static UiManagerLevel1Controller instance;

    public bool gameOver { get; set; }
    public bool hasStarted { get; set; }


    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameOver()
    {
        SpaceShipSpownerDown.instance.StopSpawn();
    }


    public void ButtonReset()
    {
        SceneManager.LoadScene("level1");
    }
    public void ButtonMainMenu()
    {
        SceneManager.LoadScene(0);
    }





}
