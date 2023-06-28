using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitShot 
{
    public GameObject bullet { get; set; }
    public void Shot();
}
