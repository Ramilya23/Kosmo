using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15.0f;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        
    }
}
