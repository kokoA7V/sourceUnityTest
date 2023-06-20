using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemiPlayerBullet : MonoBehaviour
{
    private Vector2 movePos;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        movePos = this.transform.position;
        movePos.y += 0.3f;
        this.transform.position = movePos;
    }
}
