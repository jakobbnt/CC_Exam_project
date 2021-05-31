using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrawlerMovement : MonoBehaviour
{
    Vector2 direction;
    float accuracy = 1f;
    Rigidbody2D enemyRigid;
    [SerializeField]
    float speed;
    Transform goal;
    bool playerHit;
    [SerializeField]
    float pushBack;

    void Start()
    {
        enemyRigid = this.GetComponent<Rigidbody2D>();
        goal = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().transform;
        bool playerHit = false;
    }

    // Update is called once per frame
    void Update()
    {

        toPlayer(); 
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "Player")
        {
            enemyRigid.AddForce(-direction * pushBack);
            
        }*/
    }

    //Metode som laver en vetor mellem Brawler objektet og spiller objektet
    //Den flytter så Brawleren hen mod spilleren
    void toPlayer()
    {
        direction = goal.transform.position - this.transform.position;
        print(direction);
        if (direction.magnitude > accuracy)
        {
            enemyRigid.transform.Translate(direction/2 * speed * Time.fixedDeltaTime);
        }

    }
}
