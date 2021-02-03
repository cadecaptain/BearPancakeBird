using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour

{
    public bool slapped { get; private set; } = false; 
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector3.right * Random.Range(-200, 200));
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSlapped(bool b) {
        slapped = b;
    }

}
