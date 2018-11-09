using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuToggleMute : MonoBehaviour
{

    public Toggle toggle;


	public void OnValueChanged(float newValue)
    {
        if (newValue <= 0) toggle.isOn=true;
        else toggle.isOn = false;
    }
}
