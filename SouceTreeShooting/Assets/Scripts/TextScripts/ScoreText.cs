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
            scoretx.text = "�X�R�A:" + score.ToString("d05");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))�@//����if������
            {
                score += 100; //���̐���
                scoretx.text = "�X�R�A:" + score.ToString("d05");
            }
        }
    }
}


