using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SText
{
    public class LIfeText : MonoBehaviour,IPlayerLife
    {
        public int maxHp { get; set;}
        public int nowHp { get; set; }

        public Text lifetext;

        void Start()
        {
           maxHp= 3;  //¼ÌHP
        }

        void Update()
        {
            if(Input.GetMouseButtonDown(0)) //¼Ìif¶ð
            {
                maxHp--;
                nowHp = maxHp;
                lifetext.text = nowHp.ToString();
            }
        }
    }
}

