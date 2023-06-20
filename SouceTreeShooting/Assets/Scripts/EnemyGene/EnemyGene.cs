using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGene : MonoBehaviour
{
    public GameObject enemyObj;
    public int createTime;

    private float timer;

    private Vector2 pos;

    private void Start()
    {
        pos = new Vector2(-2.75f, 3.0f);
        Instantiate(enemyObj, pos, Quaternion.identity);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= createTime)
        {
            timer = 0f;
            pos = new Vector2(Random.Range(-6f, 0.5f), Random.Range(2f, 4f));
            Instantiate(enemyObj, pos, Quaternion.identity);
        }
    }
}
