using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private Vector3 initialPosition;
    public float speed = 20f;
    public float maxDistance = 100f;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Destroy the bullet if it goes beyond a certain distance
        if (Vector3.Distance(initialPosition, transform.position) > maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Destroy the bullet when it collides with an object
        Destroy(gameObject);
    }
}
