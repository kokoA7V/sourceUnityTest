using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    int nowHP;
    public void PlDmg(int _nowHP)
    {
        Debug.Log("��������");
        nowHP = _nowHP;
        nowHP--;
    }
    public void Pldie()
    {

    }
}
