using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{

    Vector2 direction;
    Transform goal;
    float accuracy = 5f;
    [SerializeField]
    float speed = 1f;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody2D>();
        goal = GameObject.FindGameObjectWithTag("Center").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        toPlayer();
    }

    void toPlayer()
    {
        this.transform.up = new Vector2(goal.position.x - this.transform.position.x,goal.position.y - this.transform.position.y);
        //myRigidbody.AddForce(this.transform.right * 0.001f);
        this.transform.Translate(transform.right * 0.25f);
        Debug.DrawLine(transform.position, transform.up);

    }
}
