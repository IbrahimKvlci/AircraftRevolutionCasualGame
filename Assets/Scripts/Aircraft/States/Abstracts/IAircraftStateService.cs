using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAircraftStateService
{
    public IAircraftState CurrentAircraftState { get; set; }

    void Initialize(IAircraftState state);
    void SwitchState(IAircraftState state);
}
