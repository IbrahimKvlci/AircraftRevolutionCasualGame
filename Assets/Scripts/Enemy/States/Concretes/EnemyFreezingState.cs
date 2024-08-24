using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFreezingState : EnemyStateBase
{
    public EnemyFreezingState(Enemy enemy, IEnemyStateService enemyStateService) : base(enemy, enemyStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        if (_enemy.EnemyLevel!=0)
        {
            _enemyStateService.SwitchState(_enemy.EnemyPlayingState);
        }
    }

    public override void ExitState()
    {
        base.ExitState();
    }
}
