using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public int CurrentScore = 0;

    public int CurrentLife = 5;

    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + CurrentScore;
    }

    public void Score(int score)
    {
        CurrentScore =+ score;
        Debug.Log("score!");
    }

    public void loseLife()
    {
        Debug.Log("lose life!");
        CurrentLife--;
    }
}
