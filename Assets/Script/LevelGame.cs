using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGame : MonoBehaviour
{
    public void StartLevel(float number)
    {
        SceneManager.LoadScene(number.ToString(), LoadSceneMode.Single);
        Debug.Log(gameObject.name);
    }
}
