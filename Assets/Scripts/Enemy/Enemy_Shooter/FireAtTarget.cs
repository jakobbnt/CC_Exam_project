using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtTarget : MonoBehaviour
{
    ShooterMovement shooterMovement;
    float radius;
    public EnemyBullet bullet;
    Transform target;
    Rigidbody2D bulletRigid;
    public float power = 1500f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shooterMovement = GameObject.FindGameObjectWithTag("Shooter").GetComponent<ShooterMovement>();
        radius = shooterMovement.radius;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shootAtTarget(radius, bullet, target.position, bulletRigid, shooterMovement.direction.magnitude);
    }

    public void shootAtTarget(float radius, EnemyBullet bullet, Vector3 target, Rigidbody2D bulletRigid, float distance)
    {
        if (distance < radius)
        {
            timer += Time.deltaTime;
            print(timer);
            if (timer > 2f)
            {
                print("hej");
                EnemyBullet newBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
                newBullet.addForce(this.transform.up, power);
                timer = 0;
            }
            
        }
    }
}
