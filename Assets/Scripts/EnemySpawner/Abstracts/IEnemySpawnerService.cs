using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemySpawnerService
{
    void SpawnEnemyWithLevelAtPoint(Vector3 point,Enemy enemy,int enemyLevel);
}
