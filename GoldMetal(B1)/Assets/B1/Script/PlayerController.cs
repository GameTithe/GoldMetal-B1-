using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public Vector3 inputVec; // 입력 방향
    public float movePower;  // 이동 속도
    public float jumpPower;  // 점프 힘
    public bool isGround;    // 바닥 닿기 유무

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
