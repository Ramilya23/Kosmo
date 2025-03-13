using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSD : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;

    void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.y -= speed * Time.deltaTime;

        }
        if (Input.GetKey("a"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;

        }
        if (Input.GetKey ("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
        if (Input .GetKeyDown("s"))
        {
            pos.y -= speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("s"))
        {
            pos.y += speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("d"))
        {
            pos.y -= speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("d"))
        {
            pos.y += speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("d"))
        {
            pos.x -= speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("s"))
        {
            pos.x += speed * Time.deltaTime;

        }
        if (Input.GetKeyDown("s"))
        {
            pos.x -= speed * Time.deltaTime;

        }

    }
}
