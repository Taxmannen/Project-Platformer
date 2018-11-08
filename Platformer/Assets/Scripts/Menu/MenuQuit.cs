using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuQuit : MonoBehaviour {

	public void OnClick()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
