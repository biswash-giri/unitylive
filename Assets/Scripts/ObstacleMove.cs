using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();

        if (rb.position.y < -3)
        {
            Destroy(gameObject);
            
        }

    }

    private void move()
    {
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }
}

