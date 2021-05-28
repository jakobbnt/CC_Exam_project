 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face_mouse : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        faceMouse();



	}

    void faceMouse()
    {
        //Vector3 mousePosition = ;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 faceDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = faceDirection;
    }
}
