using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public void EnShot(GameObject bullet)
    {
        Debug.Log("EnemyAttack");
        if (bullet == null) return;
        Vector2 pos = new Vector2(this.transform.position.x + 0.5f, this.transform.position.y);
        GameObject _bullet = Instantiate(bullet, pos,Quaternion.identity);
        _bullet.GetComponent<IUnitAttack>().atkLayer = 2;
        _bullet.GetComponent<IUnitAttack>().atkpow = 1;
    }
}
