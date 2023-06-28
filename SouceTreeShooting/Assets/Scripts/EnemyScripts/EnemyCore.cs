using UnityEngine;

public class EnemyCore : MonoBehaviour, IUnitDamage, IUnitMove, IUnitShot
{
    public int dmgLayer { get; set; } = 2;
    public int maxHp { get; set; } = 3;
    public int nowHp { get; set; } = 3;
    public float moveSpd { get; set; } = 5;
    public GameObject bullet { get; set; }

    public void HitDmg()
    {
        nowHp--;
    }
    public void Die()
    {
        GetComponent<EnemyDamage>().EnDie();
    }

    public void Move(float spd)
    {
        GetComponent<EnemyMove>().EnMove(spd);
    }

    public void Shot()
    {
        GetComponent<EnemyShot>().EnShot(bullet);
    }
}
