using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb2d;

    [SerializeField]
    private float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void LateUpdate()
    {
        if (transform.position.x > 5.7)
        {
            transform.position = new Vector3(5.7f, transform.position.y);
        }

        if (transform.position.x <-5.7)
        {
            transform.position = new Vector3(-5.7f, transform.position.y);
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
    }
    
    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }
}
