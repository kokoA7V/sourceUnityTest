using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerAttack : MonoBehaviour
    {
        Player.PlayerCore pCore;
        [SerializeField]
        private float atkInter=2f;
        private float timer = 0;
        private Vector2 rightMuzzle;
        private Vector2 leftMuzzle;
        private GameObject parent;
        // Start is called before the first frame update
        void Start()
        {
            pCore = this.GetComponent<PlayerCore>();
            parent = this.gameObject;
            rightMuzzle = new Vector2(parent.transform.position.x + 0.4f,
                    parent.transform.position.y);
            leftMuzzle = new Vector2(parent.transform.position.x - 0.4f,
                   parent.transform.position.y);
        }

        // Update is called once per frame
        void Update()
        {          

            timer += 0.1f;
            // W–ñ‚µ‚¤‚Â
            if (Input.GetKey(KeyCode.Space))
            {
                rightMuzzle = new Vector2(parent.transform.position.x + 0.1f,
                    parent.transform.position.y);
                leftMuzzle = new Vector2(parent.transform.position.x - 0.1f,
                       parent.transform.position.y);
            }
            // L‚­‚¤‚Â
            else
            {
                rightMuzzle = new Vector2(parent.transform.position.x + 0.4f,
                    parent.transform.position.y);
                leftMuzzle = new Vector2(parent.transform.position.x - 0.4f,
                       parent.transform.position.y);
            }
            if (timer >= atkInter)
            {
                Instantiate(pCore.bullletObj, rightMuzzle, Quaternion.identity);
                Instantiate(pCore.bullletObj, leftMuzzle, Quaternion.identity);
                timer = 0;
            }
        }
    }
}

