using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{
    PlayerCore pCore;
    void Start()
    {
        pCore = GetComponent<PlayerCore>();
    }

    
    void Update()
    {
        pCore.Move();
        pCore.Shot();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<IUnitAttack>().atkLayer==pCore.dmgLayer)
        {
            return;
        }
        pCore.HitDmg();
        if (pCore.nowHp<=0)
        {
            pCore.Die();
        }
    }
}
