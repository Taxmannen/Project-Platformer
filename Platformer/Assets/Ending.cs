using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {

	void Update ()
    {
        if (Input.GetButtonDown("Submit")) SceneManager.LoadScene("Game Scene");
        if (Input.GetButtonDown("Cancel")) SceneManager.LoadScene("Start Menu Scene");
    }
}
