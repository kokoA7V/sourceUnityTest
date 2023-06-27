using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour, IAddScore
{
    int nowscore;

    public Text Scoretx;

    // Start is called before the first frame update
    void Start()
    {
        Scoretx.text = nowscore.ToString("d05");
    }

    // Update is called once per frame
    void Update()
    {
        Scoretx.text = nowscore.ToString("d05");
    }

    public void AddScore()
    {
        nowscore += 100;
    }
}

