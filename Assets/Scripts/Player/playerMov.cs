using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour {

    Rigidbody2D playeRrigid;
    float movementSpeed = 10f;
    bool boost;
	// Use this for initialization
	void Start () {
        
		playeRrigid = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {
        movement();
        boostMovement();
        //print(boost);
        //print(movementSpeed);

	}

    void movement()
    // Spillerens movement på alle axer 
    {

        if (Input.GetKey(KeyCode.W))
        {
            playeRrigid.transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playeRrigid.transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playeRrigid.transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playeRrigid.transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }

        
    }

    void boostMovement()
    // En function til at forhøje spillerens hastighed
    {

        if (boost == true)
        {
            movementSpeed = movementSpeed + 10f;
        }
        if (boost == false)
        {
            movementSpeed = 10f;
        }
           
        if (Input.GetKeyDown(KeyCode.Space))
        {
            boost = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            boost = false; 
        }
        if (movementSpeed > 20f)
        {
            movementSpeed = 20f;
        }
    }
}
