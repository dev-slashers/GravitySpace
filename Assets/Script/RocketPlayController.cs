using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlayController : MonoBehaviour
{

    // Physics value to jump, default is 200
    public float gravityJump;
    public Rigidbody2D rocketRigidbody2D;

    public static RocketPlayController instance;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rocketRigidbody2D = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (UiManagerLevel1Controller.instance.hasStarted)
            {

                rocketRigidbody2D.velocity = Vector2.zero;
                rocketRigidbody2D.AddForce(new Vector2(0, gravityJump));
           
            }
           
        }
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Footer")
        {
            UiManagerLevel1Controller.instance.GameOver();
            Destroy(gameObject, 1f);
        }
    }

  
}
