using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public void EnShot(GameObject bullet)
    {
        Debug.Log("EnemyAttack");
        if (bullet == null) return; 
        GameObject _bullet = Instantiate(bullet);
        _bullet.GetComponent<IUnitAttack>().atkLayer = 2;
        _bullet.GetComponent<IUnitAttack>().atkpow = 1;
    }
}
