﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public Vector3 velocity = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        velocity = Random.onUnitSphere * 5;
    }

    // Update is called once per frame
    void Update()
    {
        //euler physics
        velocity += new Vector3(0, -10, 0) * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        print("gg");
    }
}
