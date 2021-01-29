using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeController : MonoBehaviour
{
    Rigidbody2D physics;
    GameObject arm;
    bool attached = false;

    void Start()
    {
        arm = GameObject.Find("Arm");
        physics = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        Vector3 outFromArm = arm.transform.position - arm.transform.parent.position;
        Vector3 handPosition = arm.transform.position + .75f * outFromArm;

        float distToArm = physics.Distance(arm.GetComponent<Collider2D>()).distance;
        if (Input.GetKey(KeyCode.Space) && distToArm < .5f)
        {
            physics.gravityScale = 0;
            attached = true;
            transform.position = handPosition;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, arm.transform.rotation.eulerAngles.z));
        }
        else if (attached && Input.GetKeyUp(KeyCode.Space))
        {
            physics.gravityScale = 1;
            attached = false;

            float framerate = 1f / Time.deltaTime;

            Vector3 frameVelocity = framerate * (handPosition - transform.position);
            float length = frameVelocity.magnitude;
            Vector3 cappedVelocity = Mathf.Min(length, 40) * frameVelocity.normalized;

            physics.velocity = new Vector2(cappedVelocity.x, cappedVelocity.y);
        }

    }
}
