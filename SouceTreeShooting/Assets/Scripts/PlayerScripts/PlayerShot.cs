using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField]
    private float atkInter = 2f;
    private float timer = 0;
    private Vector2 rightMuzzle;
    private Vector2 leftMuzzle;
    private GameObject parent;
    [SerializeField]
    GameObject bullletObj;
    GameObject _LbullletObj;
    GameObject _RbullletObj;

    public void PlShot()
    {
        parent = this.gameObject;
        timer += 0.1f;
        // �W�񂵂���
        if (Input.GetKey(KeyCode.Space))
        {
            rightMuzzle = new Vector2(parent.transform.position.x + 0.1f,
                parent.transform.position.y);
            leftMuzzle = new Vector2(parent.transform.position.x - 0.1f,
                   parent.transform.position.y);
        }
        // �L������
        else
        {
            rightMuzzle = new Vector2(parent.transform.position.x + 0.4f,
                parent.transform.position.y);
            leftMuzzle = new Vector2(parent.transform.position.x - 0.4f,
                   parent.transform.position.y);
        }
        if (timer >= atkInter)
        {
            timer = 0;

            if (bullletObj == null) return;

            _RbullletObj = Instantiate(bullletObj, rightMuzzle, Quaternion.identity);
            _LbullletObj = Instantiate(bullletObj, leftMuzzle, Quaternion.identity);

            // ���C���[�̐ݒ�
            _RbullletObj.GetComponent<IUnitAttack>().atkLayer = 1;
            _LbullletObj.GetComponent<IUnitAttack>().atkLayer = 1;

            //// �_���[�W�̐ݒ�
            _RbullletObj.GetComponent<IUnitAttack>().atkpow = 1;
            _LbullletObj.GetComponent<IUnitAttack>().atkpow = 1;
        }
    }
}
