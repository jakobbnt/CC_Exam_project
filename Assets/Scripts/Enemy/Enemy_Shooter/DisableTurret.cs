using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTurret : MonoBehaviour
{
    ShooterManager shooterManager;
    // Start is called before the first frame update
    void Start()
    {
        shooterManager = this.transform.parent.gameObject.GetComponent<ShooterManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shooterManager.isDead)
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
