using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayingState : GameStateBase
{
    private float scoreTimer;
    private float scoreTimerMax;

    public GamePlayingState(GameManager gameManager, IGameStateService gameStateService) : base(gameManager, gameStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        scoreTimer = 0;
        scoreTimerMax = 0.2f;
    }

    public override void UpdateState()
    {
        base.UpdateState();
        Time.timeScale = 1;

        _gameManager.GameTime += Time.deltaTime;

        scoreTimer += Time.deltaTime;
        if(scoreTimer >= scoreTimerMax )
        {
            scoreTimer = 0;
            _gameManager.Score++;
        }

        ChangeGameDifficulty();

        BalloonSpawner.Instance.HandleBalloonSpawn();
        EnemySpawner.Instance.HandleEnemySpawn();

        if (_gameManager.IsGamePaused)
        {
            _gameStateService.SwitchState(_gameManager.GamePausedState);
        }
    }

    public override void ExitState()
    {
        base.ExitState();
        SoundManager.Instance.StopAllSoundsInPool();
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
