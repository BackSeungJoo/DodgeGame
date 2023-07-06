using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSword : MonoBehaviour
{
    public float Speed = default;
    private Rigidbody rigid = default;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * Speed; // z ����

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    // �÷��̾ ���̴� �ڵ�
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("�÷��̾�� �ε��Ƴ�?");
            PlayerControler playerControler = other.GetComponent<PlayerControler>();

            if(playerControler != null)
            {
                playerControler.Die();
            }
        }
    }

}
