using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
