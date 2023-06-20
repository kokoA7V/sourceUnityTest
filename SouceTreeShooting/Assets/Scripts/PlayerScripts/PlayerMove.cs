using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
      
        Player.PlayerCore pCore;
        Vector3 movepos;
        // Start is called before the first frame update
        void Start()
        {
            pCore = this.GetComponent<PlayerCore>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                movepos = this.transform.position;
                movepos.x += pCore.moveSpd;
                this.transform.position = movepos;
                if (this.transform.position.x > 0.4f)
                {
                    this.transform.position = new Vector3(0.4f, this.transform.position.y, this.transform.position.z);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                movepos = this.transform.position;
                movepos.x -= pCore.moveSpd;
                this.transform.position = movepos;
                if (this.transform.position.x < -6)
                {
                    this.transform.position = new Vector3(-6f, this.transform.position.y, this.transform.position.z);
                }
            }            
            if (Input.GetKey(KeyCode.W))
            {
                movepos = this.transform.position;
                movepos.y += pCore.moveSpd;
                this.transform.position = movepos;
                if (this.transform.position.y > 4.4f)
                {
                    this.transform.position = new Vector3(this.transform.position.x, 4.4f, this.transform.position.z);
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                movepos = this.transform.position;
                movepos.y -= pCore.moveSpd;
                this.transform.position = movepos;
                if (this.transform.position.y < -4.5f)
                {
                    this.transform.position = new Vector3(this.transform.position.x, -4.5f, this.transform.position.z);
                }
            }


        }
    }

}
