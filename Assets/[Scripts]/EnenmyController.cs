/*
 * EnemyManager.cs by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 24 2021
 * this file controls enemy behaviours
 * verion 1.1 A1-part2 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenmyController : MonoBehaviour
{
    private AudioSource scoresound;
    public float damage;
    public float score;
    public ScoreManagerScript scoreMgr;
    public EnemyManagerScript enemyManager;
    [SerializeField] private float speed;
    [Header("Boundary Check")] public float horizontalBoundary;
    public float verticalBoundary;

    private Rigidbody2D e_rigidBody;



    // Start is called before the first frame update
    void Start()
    {
        e_rigidBody = GetComponent<Rigidbody2D>();
        enemyManager = FindObjectOfType<EnemyManagerScript>();
        scoreMgr = FindObjectOfType<ScoreManagerScript>();
        scoresound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);

    }

    //logic when interacting with other game object
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("you are hit!");
            enemyManager.ReturnEnemy(gameObject);
            scoreMgr.loseLife();
        }
        else if (other.tag == "ScoreManager")
        {
            Debug.Log("hit(bottom)!");
            enemyManager.ReturnEnemy(gameObject);
            scoreMgr.loseLife();
        }
        else if (other.tag == "FireBall")
        {
            scoresound.Play();
            enemyManager.ReturnEnemy(gameObject);
        }
    }

}
