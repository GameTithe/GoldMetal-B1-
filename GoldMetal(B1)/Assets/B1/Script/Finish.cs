using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 스테이지 이동

            // 사운드
            other.transform.position = Vector3.up;
        }
    }
}
