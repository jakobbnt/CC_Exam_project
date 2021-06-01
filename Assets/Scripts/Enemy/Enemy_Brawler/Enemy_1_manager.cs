﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_1_manager : MonoBehaviour {
    //Fields til liv
    int enemeyHealth = 30;

    //Fields til movment
    //Transform EnemyTransform;


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        death();
    }
  
    // holder styr på modstander liv
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
          enemeyHealth = enemeyHealth - 10;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerManager>().damageTaken(15);
        }
    }

    //sørger for at spilleren dør 
    void death()
    {
        if(enemeyHealth <= 0)
        {
            var scoreManager = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>();
            scoreManager.increaseScore(10);
            Destroy(gameObject);
        }
    }
}
