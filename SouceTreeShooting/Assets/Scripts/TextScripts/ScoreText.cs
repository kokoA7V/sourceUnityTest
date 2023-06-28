using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour, IAddScore
{
    public int nowscore { get; set; }

    public Text Scoretx;

    // Start is called before the first frame update
    void Start()
    {
        nowscore = 0;
        Scoretx.text = nowscore.ToString("d05");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nowscore);
        Scoretx.text = nowscore.ToString("d05");
    }

    public void AddScore()
    {
        this.nowscore += 100;
        Debug.Log("add" + nowscore);
    }
}

