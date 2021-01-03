using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCharacter : MonoBehaviour
{

    [SerializeField] private Animator anim_;
    [SerializeField] private SpriteRenderer spriteRenderer_;
    [SerializeField] private Rigidbody2D body_;
    
    private bool facingRight_ = true;
    
    private float moveSpeed_ = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim_.Play("Walk");
        Physics2D.IgnoreLayerCollision(10, 12, true);
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        var vel = body_.velocity;
        body_.velocity = new Vector2(moveSpeed_, vel.y);
    }
    
    void Flip()
    {
        spriteRenderer_.flipX = !spriteRenderer_.flipX;
        facingRight_ = !facingRight_;
        moveSpeed_ = -moveSpeed_;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("LeftWaypoint") && !facingRight_)
        {
            Flip();
            
        }
        if (other.gameObject.CompareTag("RightWaypoint") && facingRight_)
        {
            Flip();
        }
    }
}
