using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 parent = Camera.main.WorldToScreenPoint(transform.parent.position);
        Vector3 self = Camera.main.WorldToScreenPoint(transform.position);
        float angleToMouse = angleBetween(Input.mousePosition, parent);
        float angleToSelf = angleBetween(self, parent);

        //Debug.Log("mouse: " + Input.mousePosition);
        //Debug.Log("this: " + Camera.main.WorldToScreenPoint(transform.parent.position));
        //Debug.Log("diff: " + (angleToMouse - angleToSelf));
        transform.RotateAround(transform.parent.position,Vector3.forward, (angleToMouse - angleToSelf));
        
    }

    float angleBetween(Vector3 u, Vector3 v) {
        Vector3 diff = u - v;
        return Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
    }

}