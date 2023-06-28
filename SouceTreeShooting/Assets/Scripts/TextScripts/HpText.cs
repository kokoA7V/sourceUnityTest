using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{
    private int _nowHp;
    [SerializeField]
    Text hpText;
    [SerializeField]
    PlayerCore player;
    // Update is called once per frame
    void Update()
    {
        player.GetComponent<PlayerCore>().nowHp = _nowHp;
        hpText.text = "Žc‹@  "+_nowHp.ToString();
    }
}
