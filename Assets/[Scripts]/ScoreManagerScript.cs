using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerScript : MonoBehaviour
{
    public int CurrentScore;

    public int CurrentLife;

    public Text lifeText;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + 0;
        lifeText.text = "Life: " + 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score(int score)
    {
        CurrentScore += score;
        scoreText.text = "Score: " + CurrentScore;
        Debug.Log(CurrentScore);
    }

    public void loseLife()
    {
        checkLife();
        CurrentLife = CurrentLife-1;
        Debug.Log(CurrentLife);
        updateLife();
        checkLife();
        
    }

    private void checkLife()
    {
        if (CurrentLife == 0)
        {
            Debug.Log("you ded");
            SceneManager.LoadScene("End");
        }
    }

    private void updateLife()
    {
        lifeText.text = "Life: " + CurrentLife;
    }

   
}
