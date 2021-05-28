using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerManager : MonoBehaviour {

    int playerHealth = 100;
    bool playerDeath;
    Transform playerTransform;
    public Slider healthSlider;

	// Use this for initialization
	void Start () {
        playerTransform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        death();
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerHealth = 0;
        }
        //print(playerHealth);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") playerHealth = playerHealth - 10;
       //healthSlider.value = playerHealth;
    }

 

    void damageTaken()
    {
        
    }

    void death()
    {
        if(playerHealth <= 0)
        {
            playerDeath = true;
           
        }
        if(playerDeath == true)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }


}
