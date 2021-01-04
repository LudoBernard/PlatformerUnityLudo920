using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance_;
    private FMOD.Studio.Bus bus_;
    
    [SerializeField] [Range(-80f, 10f)] private float busVolume_;
    private float volume_;

    private void Start()
    {
        bus_ = FMODUnity.RuntimeManager.GetBus("bus:/Bus");
    }
    
    private void Update()
    {       
        volume_ = Mathf.Pow(10.0f, busVolume_ / 20f);
        bus_.setVolume(volume_);
    }
}
