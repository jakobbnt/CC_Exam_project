using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    ShooterManager shooterManager;
    Transform center;
    float rotationSpeed = 20f;
    float speed = 0.25f;
    public float radius { get;} = 8.5f;
    public Vector3 direction { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        center = GameObject.FindGameObjectWithTag("Center").GetComponent<Transform>();
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,90);
        shooterManager = this.GetComponent<ShooterManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!shooterManager.isDead)
        {
            toCenter();
        }
    }

    void toCenter()
    {
        direction = center.position - this.transform.position;
        if (direction.magnitude > radius)
        {
            this.transform.Translate(direction * speed * Time.deltaTime);

        }
        else
        {
            rotateAroundCenter();
        }
    }
    void rotateAroundCenter()
    {
        this.transform.RotateAround(center.position, new Vector3(0, 0, this.transform.position.z), rotationSpeed * Time.deltaTime);
    }

    
}
