using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class MenuSliderPressed : MonoBehaviour, IPointerDownHandler
{

    public Slider slider;
    public Toggle toggle;


        public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " Was Clicked.");
    }
}
