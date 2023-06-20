using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHitInfo
{
    int Health { get; }
    void TakeDamage(int value);
}
