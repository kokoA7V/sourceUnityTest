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
            // Health‚ª0‚É‚È‚Á‚½ê‡‚Ìˆ—
            Debug.Log("EnemyKill");
            Destroy(gameObject);
        }
    }
}

