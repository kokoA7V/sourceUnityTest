using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void EnHitDmg()
    {
        //GetComponent<EnemyCore>().nowHp--;
    }

    public void EnDie()
    {
        Debug.Log("EnemyDie");
        Destroy(gameObject);
    }
}
