using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHatch : MonoBehaviour
{
    public GameObject bird;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Birdfly", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Birdfly()
    {
        Instantiate(bird);
    }
}
