using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSpownerDown : MonoBehaviour
{
    public GameObject gameObjectAlien;
    public GameObject gameObjectRocket;
    public static SpaceShipSpownerDown instance;


    void Awake()
    {
        instance = this;
    }


    void SpawnObject()
    {
       
        Instantiate(gameObjectAlien, new Vector3(transform.position.x, Random.Range(1f, 4f), 0),Quaternion.identity);


        if(UiManagerLevel1Controller.instance.score > 5) Instantiate(gameObjectRocket);

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
