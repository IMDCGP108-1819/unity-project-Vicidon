using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb2d;

    float moveHorizontal;

    void Start () {

        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    private void Update()
    {
        
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;

    }
}
