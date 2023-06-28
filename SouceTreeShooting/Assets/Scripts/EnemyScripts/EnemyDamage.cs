using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void EnDie()
    {
        Debug.Log("EnemyDie");
        Destroy(gameObject);
    }
}
