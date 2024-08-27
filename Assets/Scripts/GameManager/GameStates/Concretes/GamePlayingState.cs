using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayingState : GameStateBase
{
    private float scoreTimer;
    private float scoreTimerMax;
    private float highScoreTimer;

    private IGameReadyService _gameReadyService;

    public GamePlayingState(GameManager gameManager, IGameStateService gameStateService, IGameReadyService gameReadyService) : base(gameManager, gameStateService)
    {
        _gameReadyService = gameReadyService;
    }

    public override void EnterState()
    {
        base.EnterState();
        _gameReadyService.GameStart();

        scoreTimer = 0;
        scoreTimerMax = 0.2f;
        highScoreTimer = 0;
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

        highScoreTimer += Time.deltaTime;
        if (_gameManager.Score > _gameManager.HighScore&&highScoreTimer>=10f)
        {
            highScoreTimer = 0;
            _gameManager.HighScore = _gameManager.Score;
        }
    }

    public override void ExitState()
    {
        base.ExitState();
        _gameReadyService.GameStop();

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
