using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementManager : IEnemyMovementService
{
    public void HandleMovement(Enemy enemy,float speed)
    {
        enemy.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
