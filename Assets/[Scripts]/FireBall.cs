using System.Collections;
using System.Collections.Generic;
using System.Media;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;
    public float veriticalBoundary;
    public BulletManager bulletMgr;
    
    public ScoreManagerScript scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        bulletMgr = FindObjectOfType<BulletManager>();
        scoreManager = FindObjectOfType<ScoreManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        CheckBounds();
    }
    
    void move()
    {
        transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
    }

    private void CheckBounds()
    {
       
            if (transform.position.y > veriticalBoundary)
            {
                bulletMgr.ReturnBullet(gameObject);
            }
    }
    
    //check if bullets are colliding with other game object. if they are, then return them to the pool
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag =="Enemy")
        {
            bulletMgr.ReturnBullet(gameObject);
            scoreManager.Score(100);
        }
        
        if (other.tag =="Coin")
        {
            bulletMgr.ReturnBullet(gameObject);
            scoreManager.Score(50);
        }
        
    }
}
