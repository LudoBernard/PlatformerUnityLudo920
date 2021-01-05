using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance_;
    [FMODUnity.EventRef] [SerializeField] private string menuMusic_ = "";
    // Start is called before the first frame update
    private void Awake()
    {
        if (!instance_)
        {
            instance_ = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        FMODUnity.RuntimeManager.PlayOneShot(menuMusic_);
    }
}
