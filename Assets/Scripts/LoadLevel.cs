using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public Scene curScene;

    // Use this for initialization
    void Start(int level)
    {
        SceneManager.LoadScene("Level_" + level);
        SceneManager.UnloadSceneAsync(curScene);
    }
}