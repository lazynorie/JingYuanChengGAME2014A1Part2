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

    public Animator animator;
    [Header("Player Speed")]
    [SerializeField] 
    private float moveSpeed = 1.0f;
    public float horizontalSpeed;
    public float verticalSpeed;
    public float horizontalTValue;

    [Header("Boundary Check")]
    public float horizontalBoundary;

    public float verticalBoundary;
    
    [Header("Player Firing")]
    public float fireDelay;
   
    // Private variables
    private Rigidbody2D m_rigidBody;
    private Vector3 m_touchesEnded;
    private float ydirection = 0.0f;
    private float xdirection = 0.0f;
    
    void Start()
    {
       
        m_touchesEnded = new Vector3();
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("PlayerSpeed", m_rigidBody.velocity.x);
        Move();
        CheckBounds();
    }

    private void Move()
    {
        

        foreach (var touch  in Input.touches)
        {
            var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);

            if (worldTouch.y > transform.position.y)
            {
                // direction is positive
                ydirection = 1.0f;
            }

            if (worldTouch.y < transform.position.y)
            {
                // direction is negative
                ydirection = -1.0f;
            }
            
            if (worldTouch.x > transform.position.x)
            {
                // direction is positive
                xdirection = 1.0f;
            }

            if (worldTouch.x < transform.position.x)
            {
                // direction is negative
                xdirection = -1.0f;
            }
            m_touchesEnded = worldTouch;
        }
        //keyboard support

        if (Input.GetAxis("Vertical") >= 0.1f) 
        {
            // direction is positive
            ydirection = 1.0f;
        }

        if (Input.GetAxis("Vertical") <= -0.1f)
        {
            // direction is negative
            ydirection = -1.0f;
        }
            
        if (Input.GetAxis("Horizontal") >= 0.1f) 
        {
            // direction is positive
            xdirection = 1.0f;
        }

        if (Input.GetAxis("Horizontal") <= -0.1f)
        {
            // direction is negative
            xdirection = -1.0f;
        }
        
        if (m_touchesEnded.y != 0.0f)
        {
            transform.position = new Vector2(Mathf.Lerp(transform.position.x, m_touchesEnded.x, horizontalTValue),transform.position.y);
        }
        else
        {
            Vector2 newVelocity = m_rigidBody.velocity + new Vector2(xdirection * verticalSpeed, ydirection * horizontalSpeed);
            m_rigidBody.velocity = Vector2.ClampMagnitude(newVelocity, moveSpeed);
            m_rigidBody.velocity *= 0.99f;
        }
    }

    private void CheckBounds()
    {
        //check right bounds
        if (transform.position.x >= horizontalBoundary)
        { 
            transform.position = new Vector3(horizontalBoundary, transform.position.y, 0.0f);
        }
        
        //check left bounds
        if (transform.position.x <= -horizontalBoundary )
        { 
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, 0.0f);
        }

        
    }
}
