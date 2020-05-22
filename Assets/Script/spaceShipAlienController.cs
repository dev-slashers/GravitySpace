using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipAlienController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedTime;
    Rigidbody2D alienRigidbody2D;


    void Start()
    {
        alienRigidbody2D = GetComponent<Rigidbody2D>();
        InvokeRepeating("MoveSpace", 0.1f, 1f);
    }



    void MoveSpace()
    {
        alienRigidbody2D.velocity = new Vector2((speedTime), 1f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
