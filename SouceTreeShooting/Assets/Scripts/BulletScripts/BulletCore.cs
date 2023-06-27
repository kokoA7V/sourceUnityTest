using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCore :MonoBehaviour, IUnitMove, IUnitAttack
{
    public int moveSpd { get; set; }

    public int atkpow { get; set; }
    public int atkLayer { get; set; }

    public void Move(int spd)
    {
        if (atkLayer == 1)
        {
            Vector2 pos = transform.position;
            pos.y += spd;
            transform.position = pos;
        }
        else if (atkLayer == -1)
        {
            Vector2 pos = transform.position;
            pos.y -= spd;
            transform.position = pos;
        }
    }
}
