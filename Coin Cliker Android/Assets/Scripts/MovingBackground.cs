﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{

    public float speed = 1f; // for bacvkground speed movements
    public float clamppos ; // for clamping position

    [HideInInspector] public Vector3 StartPosition ; // get our first position


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    void FixedUpdate()
    {
        float NewPosition = Mathf.Repeat(Time.time * speed, clamppos);
        transform.position = StartPosition + Vector3.down * NewPosition ;
    }
}
