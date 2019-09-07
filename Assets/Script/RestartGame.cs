using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public string NumberScene;

    private void OnCollisionEnter(Collision other) 
    {
        SceneManager.LoadScene(NumberScene, LoadSceneMode.Single);
    }
}
