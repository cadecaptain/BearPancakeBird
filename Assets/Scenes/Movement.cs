using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left) ;
        }

    }
}