using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerManager : MonoBehaviour {

    int playerHealth = 100;
    public bool playerDeath;
    Transform playerTransform;
    public Slider healthBar;

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
        healthBar.value = playerHealth;
	}
    
    public void damageTaken(int damage)
    {
        playerHealth -= damage;
    }

    void death()
    {
        if(playerHealth <= 0)
        {
            playerDeath = true;
           
        }
        if(playerDeath == true)
        {
            this.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("GameOverText").GetComponent<GameEnder>().GameisOver();

        }
    }


}
