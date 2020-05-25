using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSpownerUp : MonoBehaviour
{
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
        Instantiate(gameObjectAlien, new Vector3(transform.position.x, Random.Range(1f, 4f), 0), Quaternion.identity);
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
