using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_fire : MonoBehaviour {
    [SerializeField] 
    private float bullet_force;
    
    private void OnTriggerEnter2D(Collider2D target)
    {
        // får skudet til at flyve frem
        if (target.gameObject.tag == "FirePoint") 
        { 
            GetComponent<Rigidbody2D>().AddForce(this.transform.up * bullet_force);         
        }
        // får skudet til at forsvinde efter det rammer "Border"
        if (target.gameObject.tag == "Border" || target.gameObject.tag == "Enemy" || target.gameObject.tag == "Shooter") Destroy(gameObject);
        
    }

}
