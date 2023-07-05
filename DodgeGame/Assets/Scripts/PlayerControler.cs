using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRigid = default;
    public float speed = 8f;

    void Start()
    {
        playerRigid = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 위에 껀 가속도가 있음
        //// 플레이어가 이동할 수 있게 하는 로직
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigid.AddForce(0f, 0f, speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigid.AddForce(0f, 0f, -speed);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigid.AddForce(speed, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigid.AddForce(-speed, 0f, 0f);
        //}
        //    // } 플레이어가 이동할 수 있게 하는 로직 end

        // 아래껀 가속도가 없음
        // Input을 Axis로 받음 (이렇게 하면 이동하는 로직을 주렁주렁 안달아도 됨.
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigid.velocity = newVelocity;

    }   // Update

    public void Die()
    {
        // 내 자신의 게임 오브젝트를 말함.
        // 내 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
