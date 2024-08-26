using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBase : IGameState
{
    protected GameManager _gameManager;
    protected IGameStateService _gameStateService;

    public GameStateBase(GameManager gameManager,IGameStateService gameStateService)
    {
        _gameManager = gameManager;
        _gameStateService=gameStateService;
    }

    public virtual void EnterState()
    {
    }

    public virtual void ExitState()
    {
    }

    public virtual void UpdateState()
    {
        if (_gameManager.IsGameOver)
        {
            _gameStateService.SwitchState(_gameManager.GameOverState);
        }
    }
}
