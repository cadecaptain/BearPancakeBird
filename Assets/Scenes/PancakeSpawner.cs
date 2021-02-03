using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeSpawner : MonoBehaviour
{
    public GameObject pancake;

    void Start() => InvokeRepeating("SpawnPancake", 0f, 6f);

    void SpawnPancake() => Instantiate(pancake, 
                                       transform.position + 2 * Vector3.up,
                                       Quaternion.Euler(0,0,90));
}
