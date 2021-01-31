using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHatch : MonoBehaviour
{
    public GameObject bird;

    void Start() => InvokeRepeating("Birdfly", 2f, 2f);

    void Birdfly() => Instantiate(bird);
}
