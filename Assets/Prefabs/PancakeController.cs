using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeController : MonoBehaviour
{
    Rigidbody2D physics;
    GameObject hand;
    GameObject arm;
    bool attached = false;
    static bool instance_attached = false;//used to communicate that another instance is attached, in which case this one can't be grabbed if it isn't already

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
            instance_attached = false;
        }
        else if (attached || (!instance_attached && Input.GetKey(KeyCode.Space) && distToHand < 1f))
        {
            transform.position = hand.transform.position;
            transform.rotation = arm.transform.rotation;
            attached = true;
            instance_attached = true;
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.name);
        
        if (other.gameObject.name.StartsWith("Bird"))
        {
            Vector2 push = other.GetContact(0).normal;
            other.rigidbody.AddForce(-5000 * push);
        }
    }
}
