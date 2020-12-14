using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GemsFloating : MonoBehaviour
{
    private float originalY_;
    private float floatStrength_ = 0.1f;

    void Start()
    {
        originalY_ = transform.position.y;
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x,
            originalY_ + (float)Math.Sin(Time.time) * floatStrength_);
    }
    
}
