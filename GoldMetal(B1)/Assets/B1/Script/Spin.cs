using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
               
    }
}
