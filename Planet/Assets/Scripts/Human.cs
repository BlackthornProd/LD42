﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    public float minSpeed;
    public float maxSpeed;
    private float speed;

    int randDir;
    bool done;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        randDir = Random.Range(0, 2);
 
    }

    private void Update()
    {
        if (randDir == 0)
        {
         
            transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
        }
        else {
            if (done == false) {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1);
                done = true;
            }
           
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
      
    }

}
