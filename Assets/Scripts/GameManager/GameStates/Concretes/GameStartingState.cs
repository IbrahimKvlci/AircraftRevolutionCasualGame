using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartingState : GameStateBase
{
    EnemySO _enemySO;

    public GameStartingState(GameManager gameManager, IGameStateService gameStateService,EnemySO enemySO) : base(gameManager, gameStateService)
    {
        _enemySO = enemySO;
    }

    public override void EnterState()
    {
        base.EnterState();


        _gameManager.ResetGame();

        _gameStateService.SwitchState(_gameManager.GamePlayingState);
    }

    public override void UpdateState()
    {
        base.UpdateState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }
}
