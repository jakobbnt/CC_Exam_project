using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public Rigidbody2D myRigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerManager>().damageTaken(20);
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Border") Destroy(this.gameObject);
    }
    public void addForce(Vector3 target, float force)
    {
        myRigid.AddForce(target*force);
    }
}
