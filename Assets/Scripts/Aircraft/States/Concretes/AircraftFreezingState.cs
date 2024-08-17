using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftFreezingState : AircraftStateBase
{
    public AircraftFreezingState(Aircraft aircraft, IAircraftStateService aircraftStateService) : base(aircraft, aircraftStateService)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        _aircraftStateService.SwitchState(_aircraft.AircraftMovingState);
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
