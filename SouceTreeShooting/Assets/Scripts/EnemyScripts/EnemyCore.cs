using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCore : MonoBehaviour,IUnitDamage,IUnitMove,IUnitShot
{
    public int dmgLayer { get; set; } = 2;
    public int maxHp { get; set; } = 3;
    public int nowHp { get; set; } = 3;
    public int moveSpd { get; set; } = 5;

    public void HitDmg()
    {
        //GetComponent<EnemyDamage>().EnHitDmg();
        nowHp--;
    }
    public void Die()
    {
        GetComponent<EnemyDamage>().EnDie();
    }

    public void Move()
    {
        GetComponent<EnemyMove>().EnMove(moveSpd);
    }

    public void Shot()
    {
        //GetComponent<EnemyShot>().
    }
}
