using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Spawner : MonoBehaviour {


    public GameObject bullet;
    public Transform bullet_Spawn;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update() {

        bool shoot = Input.GetButtonDown("Fire1");
        if (shoot){
            Instantiate(bullet, bullet_Spawn.position, bullet_Spawn.rotation);
            audioSource.Play();
        } 
        
	}
}
