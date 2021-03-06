/*
 * EnemySpawnPoint.cs by Jing Yuan Cheng 
 * Student number: 101257237
 * Date last modified: Oct 24 2021
 * this is a spawn point for enemy
 * verion 1.1 A1-part2 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawnPoint : MonoBehaviour
{
    public AudioSource spawnSound;
    public EnemyManagerScript EnemyManager;
    // Start is called before the first frame update
    void Start()
    {
        spawnSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _SpawnEnemy();
    }
    
    //function that spawns enemy in certain location
    private void _SpawnEnemy()
    {
        float xValue = Random.Range(-1.9f, 1.9f);
        // delay bullet firing 
        if(Time.frameCount % 60 == 0 && EnemyManager.HasBullets())
        {
            Vector3 haha = new Vector3(xValue, 5.5f, 0);
            //EnemyManager.GetBullet(xValue, 5.5,0);
            EnemyManager.GetBullet(haha);

        }
    }
}
