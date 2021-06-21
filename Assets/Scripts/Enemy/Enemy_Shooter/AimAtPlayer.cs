using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAtPlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        aimAtTarget();
        
    }

    void aimAtTarget()
    {
        Vector3 target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
        Vector3 direction = new Vector3(target.x - this.transform.position.x, target.y - this.transform.position.y);
        transform.up = direction;
    }
}
