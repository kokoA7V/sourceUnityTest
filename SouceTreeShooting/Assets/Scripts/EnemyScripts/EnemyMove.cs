using UnityEngine;
using Enemy;

public class EnemyMove : MonoBehaviour
{
    EnemyCore enemy;

    private Rigidbody2D rb2d;

    private const float leftBorder = -6.0f;
    private const float rightBorder = 0.5f;

    private int moveInput = 1;

    void Start()
    {
        enemy = GetComponent<EnemyCore>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.x <= leftBorder) moveInput = 1;
        if (transform.position.x >= rightBorder) moveInput = -1;

        rb2d.velocity = new Vector2(enemy.moveSpd * moveInput, rb2d.velocity.y);
    }
}
