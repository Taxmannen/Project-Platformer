using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class MenuSliderPressed : MonoBehaviour
{

    public Slider slider;
    public Toggle toggle;


        public void OnClicked()
        {
            if (slider.value <= 0) toggle.isOn = false;
            else toggle.isOn = true;
        }
}
