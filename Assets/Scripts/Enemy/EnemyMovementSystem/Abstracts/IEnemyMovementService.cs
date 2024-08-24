using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyMovementService
{
    void HandleMovement(Enemy enemy,float speed);
}