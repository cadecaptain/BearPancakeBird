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
        GameObject[] allPancakes = GameObject.FindGameObjectsWithTag("Pancake");
        int i = Random.Range(0, allPancakes.Length - 1);
        GameObject targetPancake = allPancakes[i];
        Debug.Log("Going after pancake: " +i);
        Vector3 toTarget = targetPancake.transform.position - this.transform.position;
        float speed = Random.Range(10f,20f);
        rb2D.AddForce(toTarget * speed);
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void SetSlapped(bool b) {
        slapped = b;
    }

}
