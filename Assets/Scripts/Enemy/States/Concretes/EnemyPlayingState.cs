using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayingState : EnemyStateBase
{
    private IEnemyMovementService _enemyMovementService;

    public EnemyPlayingState(Enemy enemy, IEnemyStateService enemyStateService, IEnemyMovementService enemyMovementService) : base(enemy, enemyStateService)
    {
        _enemyMovementService = enemyMovementService;
    }

    public override void EnterState()
    {
        base.EnterState();

        _enemy.EnemyHealth.SetHealthByLevel(_enemy.EnemySO.healthMultiplier,_enemy.EnemyLevel);
        _enemy.EnemyVisual.SetEnemyVisualByLevel(_enemy.EnemySO.minVisualScale,_enemy.EnemySO.maxVisualScale,_enemy.EnemySO.maxLevel,_enemy.EnemyLevel);
    }

    public override void UpdateState()
    {
        base.UpdateState();

        HandleMovement();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    private void HandleMovement()
    {
        _enemyMovementService.HandleMovement(_enemy,_enemy.EnemySO.speed);
    }
}
