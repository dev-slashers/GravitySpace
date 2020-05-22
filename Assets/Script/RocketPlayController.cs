using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlayController : MonoBehaviour
{

    // Physics value to jump, default is 200
    public float gravityJump;
    Rigidbody2D rocketRigidbody2D;

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
                SpaceShipSpownerDown.instance.StartSpawn();
            }
            else
            {
                UiManagerLevel1Controller.instance.hasStarted = true;
                rocketRigidbody2D.isKinematic = false;
            }
        }
    }
}
