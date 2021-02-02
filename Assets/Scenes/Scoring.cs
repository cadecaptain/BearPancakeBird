using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.ToLower().StartsWith("bird"))
        {
            Destroy(collision.gameObject);
            GameManage.Instance.IncScore(1);
        }

    }
}
