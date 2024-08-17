using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftStateBase : IAircraftState
{
    protected Aircraft _aircraft;
    protected IAircraftStateService _aircraftStateService;

    public AircraftStateBase(Aircraft aircraft,IAircraftStateService aircraftStateService)
    {
        _aircraft = aircraft;
        _aircraftStateService = aircraftStateService;
    }

    public virtual void EnterState()
    {
    }

    public virtual void ExitState()
    {
    }

    public virtual void UpdateState()
    {
    }
}
