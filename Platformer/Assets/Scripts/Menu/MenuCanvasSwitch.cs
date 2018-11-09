using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuCanvasSwitch : MonoBehaviour {

    public GameObject OffCanvas;
    public GameObject OnCanvas;
    public GameObject MainMenuCanvas;
    public GameObject firstSelected;
    public Transform StartMenuCameraMount;


    public void Switch()
    {
        OffCanvas.SetActive(false);
        OnCanvas.SetActive(true);
        GameObject.Find ("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(firstSelected);
    }

    public void Update()
    {
        if (OffCanvas != MainMenuCanvas &&(Input.GetButtonDown("Cancel")))
        {
            Switch();
            FindObjectOfType<MenuCameraController>().SetCameraMount(StartMenuCameraMount);
        }
    }
}
