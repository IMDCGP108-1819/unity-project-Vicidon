using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int solidity = 100;
    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        solidity -= damage;
        if (solidity <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
