using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnder : MonoBehaviour
{
    Text gameOverText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>();
    }

   

    public void GameisOver()
    {
        score = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreManager>().score;
        gameOverText.text = "Game Over\nScore: " + score +"\nPress Enter to play again";
    }
}
