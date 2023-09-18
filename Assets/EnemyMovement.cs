using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 3.0f;

    void Update()
    {
        transform.Translate(new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)) * speed * Time.deltaTime);
    }

}
