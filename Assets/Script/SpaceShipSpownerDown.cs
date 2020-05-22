using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSpownerDown : MonoBehaviour
{
    //public float spawnTime;
    //public float maxPositionY;
    public GameObject gameObjectAlien;

    public static SpaceShipSpownerDown instance;


    void Awake()
    {
        instance = this;
    }


    void SpawnObject()
    {
        Instantiate(gameObjectAlien, new Vector3(transform.position.x, Random.Range(-UiManagerLevel1Controller.instance.maxPositionY, UiManagerLevel1Controller.instance.maxPositionY), 0),Quaternion.identity);
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
