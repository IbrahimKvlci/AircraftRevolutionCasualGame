using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAircraftState
{
    void EnterState();
    void UpdateState();
    void ExitState();
}
