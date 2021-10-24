/// BulletFactory.cs
/// Jing Yuan Cheng 101257237
/// Last modified: 22/10/2021
/// This script take out different bullet type from bulletpool
/// version history
/// Version 1.1 original file

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    //public GameObject fatBullet;
    //public GameObject pulsingBullet;

    public GameObject createBullet(BulletType type = BulletType.FIRE)
    {
        
        GameObject tempBullet = null;
      
        tempBullet = Instantiate(regularBullet);
       

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}