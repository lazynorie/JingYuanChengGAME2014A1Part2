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
    public Text fianlScore;
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

    //called everytime player kill an enemy or pick up a bonus
    public void Score(int score)
    {
        CurrentScore += score;
        scoreText.text = "Score: " + CurrentScore;
        
    }

    //called everytime player let a enemy pass or getting hit by an enemy
    public void loseLife()
    {
        checkLife();
        CurrentLife = CurrentLife-1;
        Debug.Log(CurrentLife);
        updateLife();
        checkLife();
        
    }
    //check if player have enough live to continue
    //also store final score in playerprefs
    private void checkLife()
    {
        if (CurrentLife == 0)
        {
            PlayerPrefs.SetInt("Final Score", CurrentScore);
            Debug.Log("you ded");
            SceneManager.LoadScene("End");
        }
    }

    //update life UI
    private void updateLife()
    {
        lifeText.text = "Life: " + CurrentLife;
    }

   
}
