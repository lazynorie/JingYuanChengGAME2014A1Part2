/*
 * GameOverScore.cs by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 24 2021
 * this file is display final score at end scene
 * verion 1.1 A1-part2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text finalscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalscore.text  ="FinalScore: " + PlayerPrefs.GetInt("Final Score");
    }
}
