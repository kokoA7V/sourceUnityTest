using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAddScore
{
    public void AddScore();
    public int nowscore { get; set; }
}