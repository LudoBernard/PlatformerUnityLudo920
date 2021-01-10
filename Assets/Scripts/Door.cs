using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator animTop_;
    [SerializeField] private Animator animBot_;

    [SerializeField] private PlayerCharacter player_;

    [SerializeField] private GameObject winScreen_;
    [SerializeField] private GameObject scoreHealthCanvas_;

    [FMODUnity.EventRef] [SerializeField] private string winEvent_ = "";

    private void Start()
    {
        animBot_.Play("BottomDoorClosed");
        animTop_.Play("TopDoorClosed");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && player_.hasKey_)
        {
            StartCoroutine("Winning");
            
        }
    }

    private IEnumerator Winning()
    {
        animBot_.Play("BottomDoorOpen");
        animTop_.Play("TopDoorOpen");
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
        winScreen_.SetActive(true);
        scoreHealthCanvas_.SetActive(false);
        FMODUnity.RuntimeManager.PlayOneShot(winEvent_);
    }
}
