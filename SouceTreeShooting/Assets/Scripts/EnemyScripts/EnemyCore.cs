using UnityEngine;

public class EnemyCore : MonoBehaviour, IUnitDamage, IUnitMove, IUnitShot
{
    public int dmgLayer { get; set; } = 2;
    public int maxHp { get; set; } = 3;
    public int nowHp { get; set; } = 3;
    public int moveSpd { get; set; } = 5;
    public GameObject bullet { get; set; }

    public void HitDmg()
    {
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
        GetComponent<EnemyShot>().EnShot(bullet);
    }
}
