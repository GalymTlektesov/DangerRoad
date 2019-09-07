using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int NumberScene;

    private void OnCollisionEnter(Collision other) 
    {
        SceneManager.LoadScene(++NumberScene, LoadSceneMode.Single);
    }
}
