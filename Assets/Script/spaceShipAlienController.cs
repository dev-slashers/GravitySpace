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


    //Engine to set Direction
    void MoveSpace()
    {
        float range = Random.Range(0, 10); //> 3 ? 2f:-1f;
        float toMove = 1f;

        if (range > 2) toMove = -2f;
        if (range > 3) toMove = 2f;
        if (range > 4) toMove = -3f;
        if (range > 5) toMove = -1f;
        if (range > 6) toMove = 4f;
        if (range > 7) toMove = -4f;
        if (range > 8) toMove = 1.5f;
        if (range > 9) toMove = -1.5f;

        alienRigidbody2D.velocity = new Vector2((-speedTime), toMove);
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "DeleteSpaceshit")
        {
            Destroy(gameObject,1f);
        }

        if(collider2D.gameObject.tag == "Player")
        {
            UiManagerLevel1Controller.instance.AddScore();
        }
    }

}
