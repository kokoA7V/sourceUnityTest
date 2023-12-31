using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private EnemyCore enemyCore;
    private float time = 0;

    public int shotTime = 3;
    public GameObject enBullet;

    void Start()
    {
        enemyCore = GetComponent<EnemyCore>();
        enemyCore.bullet = enBullet;
    }

    void Update()
    {
        time += Time.deltaTime;

        //�ړ�
        enemyCore.Move(enemyCore.moveSpd);

        //�U��
        if(time >= shotTime)
        {
            time = 0;
            enemyCore.Shot();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<IUnitAttack>(out var unitAttack))
        {
            if (unitAttack.atkLayer != 1) return;
            //Debug.Log("EnemyDamage");
            enemyCore.HitDmg();
            if (enemyCore.nowHp <= 0) enemyCore.Die();
        }
    }
}
