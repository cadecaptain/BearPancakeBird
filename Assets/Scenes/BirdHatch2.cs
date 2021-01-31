using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHatch2 : MonoBehaviour
{
    public GameObject bird2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Birdfly", 4f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Birdfly()
    {
        Instantiate(bird2);
    }
}
