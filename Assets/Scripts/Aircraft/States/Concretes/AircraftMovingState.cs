using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftMovingState : AircraftStateBase
{
    private IAircraftMovementService _aircraftMovementService;


    public AircraftMovingState(Aircraft aircraft, IAircraftStateService aircraftStateService, IAircraftMovementService aircraftMovementService) : base(aircraft, aircraftStateService)
    {
        _aircraftMovementService = aircraftMovementService;
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void UpdateState()
    {
        base.UpdateState();

        HandleMovement();
        //_aircraft.AircraftIdleShootingController.HandleIdleShooting();

    }

    public override void ExitState()
    {
        base.ExitState();
    }

    private void HandleMovement()
    {
        //_aircraftMovementService.HandleMovement(_aircraft,_aircraft.Speed);
        _aircraftMovementService.HandleMovement(_aircraft,_aircraft.TurningSpeed);
        SoundManager.Instance.PlayAudioLoopFromPool(SoundManager.Instance.AudioSO.aircraftEngineSound,0.5f);
    }


}
