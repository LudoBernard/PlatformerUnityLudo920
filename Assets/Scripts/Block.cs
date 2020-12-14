using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject keyGameObject_;
    
    
    [FMODUnity.EventRef][SerializeField] private string breakEvent_ = "";

    private GameObject key_;
    private Vector2 keyForce_ = new Vector2(0f, 200f);
    private int lives_ = 2;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("GoldenBlock"))
            {
                key_ = Instantiate(keyGameObject_, gameObject.transform.position, Quaternion.identity);
                key_.GetComponent<Rigidbody2D>().AddForce(keyForce_);
                Destroy(gameObject);
            }

            lives_--;
            if (lives_ == 0)
            {
                Destroy(gameObject);
            }
            FMODUnity.RuntimeManager.PlayOneShot(breakEvent_, transform.position);
        }
    }
}
