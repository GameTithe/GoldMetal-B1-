using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 생명력 감소

            // 사운드

            // 플레이어 원위치
            other.transform.position = Vector3.forward;
        }
    }
}
