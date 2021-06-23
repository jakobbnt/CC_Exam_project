using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtTarget : MonoBehaviour
{
    ShooterMovement shooterMovement;
    ShooterManager shooterManager;
    float radius;
    public EnemyBullet bullet;
    Transform target;
    Rigidbody2D bulletRigid;
    public float power = 1500f;
    float timer;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shooterMovement = GameObject.FindGameObjectWithTag("Shooter").GetComponent<ShooterMovement>();
        radius = shooterMovement.radius;
        timer = 0;
        this.audioSource = this.GetComponent<AudioSource>();
        shooterManager = this.GetComponent<ShooterManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!shooterManager.isDead) {
            shootAtTarget(radius, bullet, target.position, bulletRigid, shooterMovement.direction.magnitude);
        }
    }

    public void shootAtTarget(float radius, EnemyBullet bullet, Vector3 target, Rigidbody2D bulletRigid, float distance)
    {
        if (distance < radius)
        {
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                EnemyBullet newBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
                newBullet.addForce(this.transform.up, power);
                audioSource.Play();
                timer = 0;
            }
            
        }
    }
}
