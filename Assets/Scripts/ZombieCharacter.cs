using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCharatcer : MonoBehaviour
{
    private enum State
    {
        None,
        Idle,
        Walk,
        Hurt
    }
    
    [SerializeField] private Animator anim_;
    [SerializeField] private SpriteRenderer spriteRenderer_;
    [SerializeField] private Rigidbody2D body_;

    private bool facingRight_ = true;
    
    private const float MoveSpeed = 1.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
