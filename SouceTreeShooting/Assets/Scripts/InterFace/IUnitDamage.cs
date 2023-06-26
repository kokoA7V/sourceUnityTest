using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitDamage 
{
    int dmgLayer { get; set; }
    int maxHp { get; set; }
    int nowHp { get; set; }
    void HitDmg();
    void Die();
}
