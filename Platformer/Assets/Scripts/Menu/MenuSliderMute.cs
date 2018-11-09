using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuSliderMute : MonoBehaviour {

    public Slider slider;
    float previousSliderValue;

    public void OnValueChanged(bool newState)
    {
        if (newState == true)
        {
            previousSliderValue = slider.value;
            slider.value = 0;
        }
        else slider.value = previousSliderValue;
    }
}
