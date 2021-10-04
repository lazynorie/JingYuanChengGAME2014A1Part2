/*
 * PlayerMovement.cs Made by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 3 2021
 * this file is for player behaviours
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] 
    private float moveSpeed = 1.0f;

    
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(inputX * moveSpeed * Time.deltaTime, inputY * moveSpeed * Time.deltaTime, 0);
    }
}
