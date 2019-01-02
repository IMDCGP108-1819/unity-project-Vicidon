using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    public float MovementSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            transform.position.y + MovementSpeed * Time.deltaTime);

        if (transform.position.y > 5.5f)
        {
            gameObject.SetActive(false);
        }
    }
}
