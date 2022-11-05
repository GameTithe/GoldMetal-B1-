using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 점수 얻기

            // 사운드

            // 삭제
            Object.Destroy(gameObject);
        }
    }
}
