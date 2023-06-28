using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyObj;
    public int createTime;
    public GameObject score;

    private float time = 0;
    private Vector2 pos;

    void Start()
    {
        pos = new Vector2(-2.75f, 3.0f);
        GameObject enemy = Instantiate(enemyObj, pos, Quaternion.identity);
        enemy.GetComponent<EnemyDamage>().scoreText = score;
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time >= createTime)
        {
            time = 0;
            //Debug.Log("SummonEnemy");
            pos = new Vector2(Random.Range(-6.0f, 0.5f), Random.Range(2f, 4f));
            GameObject enemy = Instantiate(enemyObj, pos, Quaternion.identity);
            enemy.GetComponent<EnemyDamage>().scoreText = score;
        }
    }
}
