using UnityEngine;

public class SpaceShitController : MonoBehaviour
{
    Rigidbody2D spaceShitRigidBody2D;

    public static SpaceShitController instance;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        spaceShitRigidBody2D = GetComponent<Rigidbody2D>();
        InvokeRepeating("MoveSpace", 0.1f, 1f);
    }

    //Engine to set Direction
    void MoveSpace()
    {
        float range = Random.Range(0, 10);
        float toMove = 1f;

        if (range > 2) toMove = -2f;
        if (range > 3) toMove = 2f;
        if (range > 4) toMove = -3f;
        if (range > 5) toMove = -1f;
        if (range > 6) toMove = 4f;
        if (range > 7) toMove = -4f;
        if (range > 8) toMove = 1.5f;
        if (range > 9) toMove = -1.5f;

        spaceShitRigidBody2D.velocity = new Vector2((-UiManagerLevel1Controller.instance.spaceShitSpeed), toMove);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Footer") spaceShitRigidBody2D.velocity = new Vector2((-UiManagerLevel1Controller.instance.spaceShitSpeed), 3f);
    }

}
