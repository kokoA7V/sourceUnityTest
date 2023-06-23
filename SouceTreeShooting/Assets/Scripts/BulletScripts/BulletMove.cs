using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class BulletMove : MonoBehaviour
    {
        BulletCore bulletCore;
        Rigidbody2D rb;

        private void Start()
        {
            bulletCore = GetComponent<BulletCore>();
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            rb.velocity = new Vector2(rb.velocity.x, bulletCore.moveSpd * bulletCore.moveInput);
        }

    }
}

