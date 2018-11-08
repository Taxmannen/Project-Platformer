using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuSliderMute : MonoBehaviour {

    public Slider slider;


    public void OnValueChanged(bool newState)
    {
        if (newState == true) slider.value = 0;
        else slider.value = 0.3f;
    }
}
