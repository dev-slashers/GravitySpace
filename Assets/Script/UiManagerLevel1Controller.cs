using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManagerLevel1Controller : MonoBehaviour
{


    public float spawnTime;
    public float maxPositionY;
    public Text scoreText;

  

    public GameObject gameOverPanel;

    int score;

    public static UiManagerLevel1Controller instance;

    public bool gameOver;
    public bool hasStarted;


    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 10;
        hasStarted = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        SpaceShipSpownerDown.instance.StopSpawn();
        SpaceShipSpownerUp.instance.StopSpawn();
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
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
