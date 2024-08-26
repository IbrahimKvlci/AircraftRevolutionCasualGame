using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : GameStateBase
{
    public event EventHandler OnGameOver;

    public GameOverState(GameManager gameManager, IGameStateService gameStateService) : base(gameManager, gameStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        Time.timeScale = 0;
        OnGameOver?.Invoke(this, EventArgs.Empty);
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
