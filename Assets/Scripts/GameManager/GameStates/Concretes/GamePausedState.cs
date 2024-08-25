using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePausedState : GameStateBase
{
    public GamePausedState(GameManager gameManager, IGameStateService gameStateService) : base(gameManager, gameStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();

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
