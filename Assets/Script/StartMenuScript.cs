using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Levels", LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
