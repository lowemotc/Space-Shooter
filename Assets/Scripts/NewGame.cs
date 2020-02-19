using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{

    public void NewGameButton()
    {
        SceneManager.LoadScene("Level_1");
    }
}