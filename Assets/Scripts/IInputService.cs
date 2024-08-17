using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputService
{
    bool AircraftTurnLeftKeyDown();
    bool AircraftTurnRightKeyDown();
    Vector3 GetMousePositionOnWorldPoint();
    public Vector3 GetMousePositionOnATarget();
}
