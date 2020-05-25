using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShitMotherController : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(-1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player") UiManagerLevel1Controller.instance.GameOver();
        if (collider2D.gameObject.tag == "DeleteSpaceshit") Destroy(gameObject, 6f);
    }
}
