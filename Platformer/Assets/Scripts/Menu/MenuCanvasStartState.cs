using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvasStartState : MonoBehaviour {

    public GameObject[] OffCanvas;
    public GameObject OnCanvas;


    void Start()
    {
        OffCanvas[0].SetActive(false);
        OffCanvas[1].SetActive(false);
        OffCanvas[2].SetActive(false);
        OffCanvas[3].SetActive(false);

        OnCanvas.SetActive(true);
    }
}
