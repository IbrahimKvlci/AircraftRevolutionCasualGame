using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftStateManager : IAircraftStateService
{
    public IAircraftState CurrentAircraftState { get; set; }

    public void Initialize(IAircraftState state)
    {
        CurrentAircraftState = state;
        state.EnterState();
    }

    public void SwitchState(IAircraftState state)
    {
        CurrentAircraftState.ExitState();
        CurrentAircraftState = state;
        CurrentAircraftState.EnterState();
    }
}
