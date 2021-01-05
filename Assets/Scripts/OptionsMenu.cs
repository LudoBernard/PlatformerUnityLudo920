using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    private FMOD.Studio.Bus sfx_;
    private FMOD.Studio.Bus music_;

    private float musicVolume_ = 0.5f;
    private float sfxVolume_ = 0.5f;

    private void Awake()
    {
        sfx_ = FMODUnity.RuntimeManager.GetBus("bus:/Master/Sounds");
        music_ = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
    }

    private void Update()
    {
        sfx_.setVolume(sfxVolume_);
        music_.setVolume(musicVolume_);
    }

    public void SfxVolumeLevel(float newSfxVolume)
    {
        sfxVolume_ = newSfxVolume;
    }

    public void MusicVolumeLevel(float newMusicVolume)
    {
        musicVolume_ = newMusicVolume;
    }
}
