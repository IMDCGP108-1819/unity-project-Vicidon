using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpaceshipShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject[] BulletPool;
    public int MaxBullets;
    
   
    // Use this for initialization
    void Start()
    {
        BulletPool = new GameObject[MaxBullets];

        for (int i = 0; i < MaxBullets; i++)
        {
            BulletPool[i] = Instantiate(BulletPrefab);
            BulletPool[i].SetActive(false);
        }
    }

    private GameObject GetSpareBullet()
    {
        for (int i = 0; i < MaxBullets; i++)
        {
            if (BulletPool[i].activeSelf == false)
            {
                return BulletPool[i];
            }
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            GameObject bullet = GetSpareBullet();

           if (bullet != null)
           {
                bullet.SetActive(true);
                bullet.transform.position = transform.position;
           }
        }
    }

}
