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
        _nowHp = player.GetComponent<PlayerCore>().nowHp;
        hpText.text = _nowHp.ToString();
    }
}
