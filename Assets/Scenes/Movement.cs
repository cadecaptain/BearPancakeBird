using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float playerSpeed = 10f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(playerSpeed * Time.deltaTime * Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            controller.Move(playerSpeed * Time.deltaTime * Vector3.left);
        }
    }
}
