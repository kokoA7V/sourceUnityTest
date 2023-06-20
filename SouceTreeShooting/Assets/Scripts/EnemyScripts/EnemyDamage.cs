using UnityEngine;
using Enemy;

public class EnemyDamage : MonoBehaviour, IHitInfo
{
    public int Health => _health;

    private int _health;

    void Start()
    {
        EnemyCore enemy = GetComponent<EnemyCore>();
        _health = enemy.maxHp;
    }

    public void TakeDamage(int value)
    {
        _health -= value;
        if (_health <= 0)
        {
            // Health��0�ɂȂ����ꍇ�̏���
            Debug.Log("EnemyKill");
            Destroy(gameObject);
        }
    }
}

