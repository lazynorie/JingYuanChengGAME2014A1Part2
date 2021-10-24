/*
 * UIBehavious.cs Made by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 24 2021
 * this file is for UI behaviours
 * verion 1.1 A1-part2 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    private AudioSource clickSound;
    private int nextSceneIndex;
    private int previousSceneIndex;

    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        clickSound = GetComponent<AudioSource>();
    }

    public void OnNextButtonPressed()
    {
        clickSound.Play();
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnBackButtonPressed()
    {
        clickSound.Play();
        SceneManager.LoadScene(previousSceneIndex);
    }

    public void onMainMenuButtonPress()
    {
        clickSound.Play();
        SceneManager.LoadScene("Start");
        
    }

    public void onHelpButtonPressed()
    {
        clickSound.Play();
        SceneManager.LoadScene("Help");
    }
    
}
