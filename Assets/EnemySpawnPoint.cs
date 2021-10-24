using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public EnemyManagerScript EnemyManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _SpawnEnemy();
    }
    
    private void _SpawnEnemy()
    {
        // delay bullet firing 
        if(Time.frameCount % 500 == 0 && EnemyManager.HasBullets())
        {
            EnemyManager.GetBullet(transform.position);
        }
    }
}
