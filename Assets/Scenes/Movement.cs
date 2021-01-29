using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D physics;

    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            physics.velocity = 10 * Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            physics.velocity = 10 * Vector3.left;
        }

    }
}
