using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public Vector3 inputVec; // �Է� ����
    public float movePower;  // �̵� �ӵ�
    public float jumpPower;  // ���� ��
    public bool isGround;    // �ٴ� ��� ����

    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //edit -> projectSetting
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.z = Input.GetAxis("Vertical");

        bool isJump = Input.GetButtonDown("Jump");

        if (isGround && isJump)
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

    }

    void FixedUpdate()
    {
        if (isGround)
        {
            rigid.AddForce(inputVec * movePower);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGround = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}
