using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score { get; set; }
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void increaseScore(int i)
    {
        score += i;
    }
}
