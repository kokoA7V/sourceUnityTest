using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SText 
{
    public class ScoreText : MonoBehaviour,IEnemyScore
    {
        public int score {get; set;}

        public Text scoretx;
        void Start()
        {
            scoretx.text = "スコア:" + score.ToString("d05");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))　//仮のif文条件
            {
                score += 100; //仮の数字
                scoretx.text = "スコア:" + score.ToString("d05");
            }
        }
    }
}


