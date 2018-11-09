using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSetSoundFXVolume : MonoBehaviour
{

    public static float SoundFXVolume;


    public void SetSoundFXVolume(float newValue)
    {
        SoundFXVolume = newValue;
    }
}
