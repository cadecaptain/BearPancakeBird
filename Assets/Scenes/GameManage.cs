using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManage : MonoBehaviour
{
    public static GameManage Instance { get; private set; }

    private int score = 0;
    public TextMeshProUGUI scoreText;
     

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score: " + score;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
