using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * bulletSpeed;
        }
    }

}
