using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : IEnemySpawnerService
{
    public void SpawnEnemyWithLevelAtPoint(Vector3 point, Enemy enemy, int enemyLevel)
    {
        Enemy spawnedEnemy=GameObject.Instantiate(enemy,point,Quaternion.Euler(0,180,0));
        spawnedEnemy.EnemyLevel=enemyLevel;
    }
}
