using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpaceShipSpownerDown : MonoBehaviour
{
    public GameObject gameObjectAlien;
    public GameObject gameObjectRocket;
    public GameObject gameObjectMother;
    public static SpaceShipSpownerDown instance;


    void Awake()
    {
        instance = this;
    }


    void SpawnObject()
    {
        
        int score = UiManagerLevel1Controller.instance.score;

        if (score > 15) Instantiate(gameObjectRocket);
        Instantiate(gameObjectAlien, new Vector3(transform.position.x, Random.Range(1f, 4f), 0),Quaternion.identity);

        if ((score.ToString().IndexOf("0") != -1) && score != 0 && score > 30) Instantiate(gameObjectMother);
        if (score >= 100) SceneManager.LoadScene("Winner");

    }


    public void StartSpawn()
    {
        InvokeRepeating("SpawnObject", 0.1f, UiManagerLevel1Controller.instance.spawnTime);
    }

    public void StopSpawn()
    {
        CancelInvoke("SpawnObject");
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
