using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public Scene curScene;
    
    public void NewGameButton()
    {
        SceneManager.LoadScene("Level_1");
        SceneManager.UnloadSceneAsync(curScene);
    }
}