using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class BulletHit : MonoBehaviour
    {
        Rigidbody2D rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            var hit = collision.gameObject.GetComponent<IHitInfo>();

            hit.TakeDamage(1);
        }
    }
}

