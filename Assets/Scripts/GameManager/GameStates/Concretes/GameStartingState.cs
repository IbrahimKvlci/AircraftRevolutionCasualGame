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
        _gameManager.EnemyLevelsByDifficulty = new List<int>(_gameManager.GameDifficultyCount);
        for (int i = 0; i < _gameManager.GameDifficultyCount; i++)
        {
            _gameManager.EnemyLevelsByDifficulty.Add(_enemySO.maxLevel / _gameManager.GameDifficultyCount * (i + 1));
        }

        _gameManager.GameTime = 0;
        _gameManager.GameDifficulty = 0;

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
