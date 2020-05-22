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

    public Text gameOverScoreText;
    public Text gameOverBestScoreText;

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
        score = 0;
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

        gameOverScoreText.text = "You Score: " + score.ToString();
        gameOverBestScoreText.text = "Best score:   " + PlayerPrefs.GetInt("bestScore").ToString();

    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
        if (PlayerPrefs.HasKey("bestScore") && score > PlayerPrefs.GetInt("bestScore")) PlayerPrefs.SetInt("bestScore", score);
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
