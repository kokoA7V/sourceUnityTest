using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitDamage 
{
    public int dmgLayer { get; set; }
    public int maxHp { get; set; }
    public int nowHp { get; set; }
    public void HitDmg();
    public void Die();
}
