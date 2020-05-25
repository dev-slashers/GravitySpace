using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManagerLevel1Controller : MonoBehaviour
{
    int score;
    public float spawnTime;


    public Text scoreText;
    public float spaceShitSpeed;

    public Text gameOverScoreText;
    public Text gameOverBestScoreText;

    public GameObject gameOverPanel;
    

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
        spaceShitSpeed += 0.5f;
        string scoreKey = "bestScore";
        scoreText.text = score.ToString();

        if (PlayerPrefs.HasKey(scoreKey) && score > PlayerPrefs.GetInt(scoreKey)) PlayerPrefs.SetInt("bestScore", score);
        if (!PlayerPrefs.HasKey(scoreKey)) PlayerPrefs.SetInt(scoreKey, score);
    }



    public void StartButton()
    {
        SpaceShipSpownerDown.instance.StartSpawn();
        SpaceShipSpownerUp.instance.StartSpawn();
        hasStarted = true;
        RocketPlayController.instance.rocketRigidbody2D.isKinematic = false;
        Destroy(GameObject.FindWithTag("StartButton"));
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
