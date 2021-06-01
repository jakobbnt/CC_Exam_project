using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextStart : MonoBehaviour
{
    Rigidbody2D ThisBody;

    // Start is called before the first frame update
    void Start()
    {
        ThisBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ThisBody.bodyType = RigidbodyType2D.Dynamic;
    }
}
