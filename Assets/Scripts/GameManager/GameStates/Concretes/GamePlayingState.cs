using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayingState : GameStateBase
{
    public GamePlayingState(GameManager gameManager, IGameStateService gameStateService) : base(gameManager, gameStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        _gameManager.GameTime += Time.deltaTime;

        ChangeGameDifficulty();

        BalloonSpawner.Instance.HandleBalloonSpawn();
        EnemySpawner.Instance.HandleEnemySpawn();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    private void ChangeGameDifficulty()
    {
        _gameManager.GameDifficulty = (int)(_gameManager.GameTime / _gameManager.DifficultyChangingTime);
        if (_gameManager.GameDifficulty > _gameManager.EnemyLevelsByDifficulty.Count - 1)
        {
            _gameManager.GameDifficulty = _gameManager.EnemyLevelsByDifficulty.Count - 1;
        }
    }
}
