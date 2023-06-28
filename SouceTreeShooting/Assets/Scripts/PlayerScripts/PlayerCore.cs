using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCore : MonoBehaviour, IUnitDamage,IUnitMove,IUnitShot
{
    public int dmgLayer { get; set; } = 1;
    public int maxHp { get; set; } = 3;
    public int nowHp { get; set; } = 3;
    public GameObject bullet { get; set; }

    public float moveSpd { get; set; } = 0.2f;
    public void Move(float spd)
    {
        GetComponent<PlayerMove>().PlMove(spd);
    }
    public void HitDmg() 
    {
        nowHp--;
    }
    public void Die()
    {
        Debug.Log("PlayerÇ™éÄÇÒÇæÅI");
        Destroy(gameObject);
    }


    public void Shot() 
    {
        GetComponent<PlayerShot>().PlShot();
    }

}
