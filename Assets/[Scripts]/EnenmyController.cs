using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenmyController : MonoBehaviour
{
    public EnemyManagerScript enemyManager;
    [SerializeField] private float speed;
    [Header("Boundary Check")]
    public float horizontalBoundary;
    public float verticalBoundary;
    
    private Rigidbody2D e_rigidBody;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        e_rigidBody = GetComponent<Rigidbody2D>();
        enemyManager = FindObjectOfType<EnemyManagerScript>();
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
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit!");
        enemyManager.ReturnEnemy(gameObject);
    }

}
