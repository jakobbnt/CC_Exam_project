using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1_manager : MonoBehaviour {
    //Fields til liv
    int enemeyHealth = 30;
    float pushBack = 10.0f;

    //Fields til movment
    Rigidbody2D enemyRigid;
    float accuracy = 1.0f;
    [SerializeField]
    float speed;
    Transform goal;
    Vector2 direction;
    //Transform EnemyTransform;


    // Use this for initialization
    void Start () {
        enemyRigid = this.GetComponent<Rigidbody2D>();
        goal = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().transform;
    }
	
	// Update is called once per frame
	void Update () {
        death();
        //print(enemeyHealth);
        toPlayer();
        
    }
  
    // holder styr på modstander liv
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
          enemeyHealth = enemeyHealth - 10;
          this.GetComponent<Rigidbody2D>().AddForce( -direction * pushBack);
        }

       
    }

    //sørger for at spilleren dør 
    void death()
    {
        if(enemeyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    // movement script til at bevæge sig mod spiller 
    void toPlayer()
    {
        Vector2 direction = goal.transform.position - this.transform.position;

        if (direction.magnitude > accuracy)
        {
            enemyRigid.transform.Translate(direction * speed * Time.fixedDeltaTime);
        }

    }
}
