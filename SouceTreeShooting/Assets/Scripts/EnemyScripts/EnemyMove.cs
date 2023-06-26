using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D rb2d = null;

    private const float leftBorder = -6.0f;
    private const float rightBorder = 0.5f;

    private int moveInput = 1;

    public void EnMove(int spd)
    {
        if(rb2d == null) rb2d = GetComponent<Rigidbody2D>();

        if (transform.position.x <= leftBorder) moveInput = 1;
        if (transform.position.x >= rightBorder) moveInput = -1;

        rb2d.velocity = new Vector2(spd * moveInput, rb2d.velocity.y);
    }
}
