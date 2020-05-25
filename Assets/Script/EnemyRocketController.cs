using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRocketController : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    public static EnemyRocketController instance;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        LaunchRocket();
    }


    void LaunchRocket()
    {
        int range = Random.Range(0, 3);
        rigidbody2D.velocity = range > 1 ? new Vector2(-3f, 2f) : new Vector2(-3f, -2f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Player") UiManagerLevel1Controller.instance.GameOver();
        if (collider2D.gameObject.tag == "DeleteSpaceshit") Destroy(gameObject, 1f);
    }
}
