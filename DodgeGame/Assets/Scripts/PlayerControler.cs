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
        // ���� �� ���ӵ��� ����
        //// �÷��̾ �̵��� �� �ְ� �ϴ� ����
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
        //    // } �÷��̾ �̵��� �� �ְ� �ϴ� ���� end

        // �Ʒ��� ���ӵ��� ����
        // Input�� Axis�� ���� (�̷��� �ϸ� �̵��ϴ� ������ �ַ��ַ� �ȴ޾Ƶ� ��.
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigid.velocity = newVelocity;

    }   // Update

    public void Die()
    {
        // �� �ڽ��� ���� ������Ʈ�� ����.
        // �� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}