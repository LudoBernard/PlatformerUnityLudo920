using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator animTop_;
    [SerializeField] private Animator animBot_;

    [SerializeField] private PlayerCharacter player_;

    private void Start()
    {
        animBot_.Play("BottomDoorClosed");
        animTop_.Play("TopDoorClosed");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && player_.hasKey_)
        {
            animBot_.Play("BottomDoorOpen");
            animTop_.Play("TopDoorOpen");
        }
    }
}
