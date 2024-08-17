using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftMovingState : AircraftStateBase
{
    private IAircraftMovementService _aircraftMovementService;
    private IInputService _inputService;

    private bool isTurning;
    private Vector3 turningStartingPos, turningEndPos;

    public AircraftMovingState(Aircraft aircraft, IAircraftStateService aircraftStateService, IAircraftMovementService aircraftMovementService, IInputService inputService) : base(aircraft, aircraftStateService)
    {
        _aircraftMovementService = aircraftMovementService;
        _inputService = inputService;
    }

    public override void EnterState()
    {
        base.EnterState();
        isTurning = false;
    }

    public override void UpdateState()
    {
        base.UpdateState();

        HandleMovement();
        _aircraft.AircraftIdleShootingController.HandleIdleShooting();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    private void HandleMovement()
    {
        _aircraftMovementService.HandleMovement(_aircraft,_aircraft.AircraftSO.speed);

        if (_inputService.AircraftTurnRightKeyDown()&&!isTurning&&!_aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.Right))
        {
            isTurning = true;
            turningStartingPos = _aircraft.transform.position;
            turningEndPos = _aircraft.transform.position + Vector3.right * 15f;
        }
        else if(_inputService.AircraftTurnLeftKeyDown() && !isTurning&&!_aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.Left))
        {
            isTurning = true;
            turningStartingPos = _aircraft.transform.position;
            turningEndPos = _aircraft.transform.position + Vector3.left * 15f;
        }

        if (isTurning)
        {
            _aircraftMovementService.HandleTurning(_aircraft, _aircraft.AircraftSO.turningTime, turningStartingPos, turningEndPos, out bool turningFinished);

            isTurning = !turningFinished;
        }
    }


}
