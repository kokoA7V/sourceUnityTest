using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void EnDie()
    {
        Debug.Log("EnemyDie");

        var system = GameSystem.ServiceLocator.Resolve<IAddScore>();
        system.AddScore();

        Destroy(gameObject);
    }
}
