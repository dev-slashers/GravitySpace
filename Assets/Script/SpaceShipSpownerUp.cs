using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSpownerUp : MonoBehaviour
{
    //public float spawnTime;
    //public float maxPositionY;
    public GameObject gameObjectAlien;

    public static SpaceShipSpownerUp instance;


    void Awake()
    {
        instance = this;
    }


    public void StartSpawn()
    {
        InvokeRepeating("SpawnObject", 2f, UiManagerLevel1Controller.instance.spawnTime);
    }

    public void StopSpawn()
    {
        CancelInvoke("SpawnObject");
    }

    void SpawnObject()
    {
        Instantiate(gameObjectAlien, new Vector3(transform.position.x, Random.Range(-UiManagerLevel1Controller.instance.maxPositionY, UiManagerLevel1Controller.instance.maxPositionY), 0), Quaternion.identity);
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
