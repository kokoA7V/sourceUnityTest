using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 movepos;

    public void PlMove(float moveSpd)
    {
        if (Input.GetKey(KeyCode.D))
        {
            movepos = this.transform.position;
            movepos.x += moveSpd;
            this.transform.position = movepos;
            if (this.transform.position.x > 0.4f)
            {
                this.transform.position = new Vector3(0.4f, this.transform.position.y, this.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            movepos = this.transform.position;
            movepos.x -= moveSpd;
            this.transform.position = movepos;
            if (this.transform.position.x < -6)
            {
                this.transform.position = new Vector3(-6f, this.transform.position.y, this.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            movepos = this.transform.position;
            movepos.y += moveSpd;
            this.transform.position = movepos;
            if (this.transform.position.y > 4.4f)
            {
                this.transform.position = new Vector3(this.transform.position.x, 4.4f, this.transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            movepos = this.transform.position;
            movepos.y -= moveSpd;
            this.transform.position = movepos;
            if (this.transform.position.y < -4.5f)
            {
                this.transform.position = new Vector3(this.transform.position.x, -4.5f, this.transform.position.z);
            }
        }


    }
}
