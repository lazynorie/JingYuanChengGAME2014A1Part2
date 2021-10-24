using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerScript : MonoBehaviour
{
    public EnemyFactoryScript EnemeyFactory;
    public int MaxEnemys;

    private Queue<GameObject> m_enemyPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildEnemyPool();
    }

    //this function build bulletpoool
    private void _BuildEnemyPool()
    {
        // create empty Queue structure
        m_enemyPool = new Queue<GameObject>();

        for (int count = 0; count < MaxEnemys; count++)
        {
            var tempBullet = EnemeyFactory.createBullet();
            m_enemyPool.Enqueue(tempBullet);
        }
    }
    //this function take out a bullet out of a pool
    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_enemyPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }

    
    public bool HasBullets()
    {
        return m_enemyPool.Count > 0;
    }

    public void ReturnEnemy(GameObject returnedEnemy)
    {
        returnedEnemy.SetActive(false);
        m_enemyPool.Enqueue(returnedEnemy);
    }
}
