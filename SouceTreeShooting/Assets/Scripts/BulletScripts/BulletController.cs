using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    BulletCore bulletCore;

    private void Start()
    {
        bulletCore = GetComponent<BulletCore>();

        bulletCore.moveSpd = 5;
    }

    private void Update()
    {
        bulletCore.Move(bulletCore.moveSpd);
    }
}
