using UnityEngine;
using Enemy;

public class EnemyAttack : MonoBehaviour, IBulletData
{
    public bool PlayerBullet => _playerBullet;

    private bool _playerBullet;

    private float timer;
    private const int time = 2;

    EnemyCore enemy;

    void Start()
    {
        enemy = GetComponent<EnemyCore>();
        _playerBullet = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= time)
        {
            timer = 0;
            Instantiate(enemy.bulletObj, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

        }
    }
}

