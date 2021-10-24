using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactoryScript : MonoBehaviour
{
    [Header("Enemy Types")]
    public GameObject enemy;
    public GameObject bonus;
    

    public GameObject createBullet(EnemyType type = EnemyType.RANDOM)
    {
        if (type == EnemyType.RANDOM)
        {
            var randomBullet = Random.Range(0, 2);
            type = (EnemyType) randomBullet;
        }

        GameObject tempEnemy = null;
        switch (type)
        {
            case EnemyType.ENEMY:
                tempEnemy = Instantiate(enemy);
                //tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case EnemyType.BONUS:
                tempEnemy = Instantiate(bonus);
                //tempBullet.GetComponent<BulletController>().damage = 20;
                break;
          
        }

        tempEnemy.transform.parent = transform;
        tempEnemy.SetActive(false);

        return tempEnemy;
    }
}
