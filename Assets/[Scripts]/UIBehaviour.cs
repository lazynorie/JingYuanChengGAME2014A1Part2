/*
 * UIBehavious.cs Made by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 3 2021
 * this file is for UI behaviours
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    private int nextSceneIndex;
    private int previousSceneIndex;

    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }

    public void onMainMenuButtonPress()
    {
        SceneManager.LoadScene("Start");
    }

    public void onHelpButtonPressed()
    {
        SceneManager.LoadScene("Help");
    }
    
    
}
