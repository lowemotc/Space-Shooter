using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    GameObject go;
    Text hiScoreText;
    int score;
    int hiScore = 20;

    private void Start()
    {
        go = GameObject.Find("HiScore");
        hiScoreText = go.GetComponent<Text>();
    }
    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString("0");

        if (score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = hiScore.ToString("0");  
        }
    }
}
