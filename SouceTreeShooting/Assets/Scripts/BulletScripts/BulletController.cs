using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    BulletCore bulletCore;
    Rigidbody2D rb;

    private void Start()
    {
        bulletCore = GetComponent<BulletCore>();
        rb = GetComponent<Rigidbody2D>();

        bulletCore.moveSpd = 0.5f;
    }

    private void Update()
    {
        bulletCore.Move(bulletCore.moveSpd);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var iud = collision.gameObject.GetComponent<IUnitDamage>();

        if (iud.dmgLayer != bulletCore.atkLayer)
        {
            Destroy(this.gameObject);
        }
    }
}
