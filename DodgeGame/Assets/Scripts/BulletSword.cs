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
        rigid.velocity = transform.forward * Speed; // z 방향

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    // 플레이어를 죽이는 코드
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("플레이어와 부딪쳤나?");
            PlayerControler playerControler = other.GetComponent<PlayerControler>();

            if(playerControler != null)
            {
                playerControler.Die();
            }
        }
    }

}
