using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject scoreText;

    public void EnDie()
    {
        Debug.Log("EnemyDie");
        if (scoreText.gameObject.TryGetComponent<IAddScore>(out var addScore))
        {
            addScore.AddScore();
            Destroy(this.gameObject);
        }
    }
}
