using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSetMusicVolume : MonoBehaviour
{

    public static float musicVolume;


    public void SetMusicVolume(float newValue)
    {
        musicVolume = newValue;
    }
}
