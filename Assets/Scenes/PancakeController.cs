using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeController : MonoBehaviour
{
    Rigidbody2D physics;
    GameObject hand;
    GameObject arm;
    bool attached = false;

    void Start()
    {
        hand = GameObject.Find("Hand");
        arm = GameObject.Find("Arm");
        physics = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        float distToHand = physics.Distance(hand.GetComponent<Collider2D>()).distance;
        if (attached && Input.GetKeyUp(KeyCode.Space))
        {
            physics.gravityScale = 1;
            transform.SetParent(null);
            attached = false;

        }
        else if (attached || (Input.GetKey(KeyCode.Space) && distToHand < 1f))
        {
            transform.position = hand.transform.position;
            transform.rotation = arm.transform.rotation;
            attached = true;
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.name);
        
        if (other.gameObject.name.StartsWith("Bird"))
        {
            Vector2 push = other.GetContact(0).normal;
            other.rigidbody.AddForce(-10000 * push);
        }
    }
}
