using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player_;
    private const float YPosition = 0;
    private const float ZPosition = -10;
    private void FixedUpdate()
    {
        transform.position = new Vector3(player_.position.x, YPosition, ZPosition);
    }
}
