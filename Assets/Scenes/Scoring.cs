using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    public GameObject Blood;

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
            bool birdRecentlySlapped = collision.gameObject.GetComponent<BirdController>().slapped;
            if (birdRecentlySlapped) {
                GameManage.Instance.IncScore(1);

                GameObject go = Instantiate(Blood);
                go.transform.position = collision.gameObject.transform.position;
                go.transform.rotation = this.gameObject.transform.rotation;


                Destroy(collision.gameObject);
                Destroy(go, 10f);
            }
        }

    }
}
