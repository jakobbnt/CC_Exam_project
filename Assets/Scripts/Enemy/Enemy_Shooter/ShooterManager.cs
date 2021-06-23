using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterManager : MonoBehaviour
{
    int health = 50;
    public bool isDead
    {
        get; set;
    }
    Animator animator;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(!isDead){
            death();
            

        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 10;
        }

    }
    void death()
    {
        if (health <= 0)
        {
            isDead = true;
            var scoreManager = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>();
            scoreManager.increaseScore(20);
            animator.SetBool("IsDead", true);
            audio.Play();
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length + 1);
        }
    }
}
