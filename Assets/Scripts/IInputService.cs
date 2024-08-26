using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputService
{
    bool AircraftTurnLeftKeyDown();
    bool AircraftTurnRightKeyDown();
    bool RocketFireButtonKey();
    Vector3 GetMousePositionOnWorldPoint();
    Vector3 GetMousePositionOnATarget();
    Vector2 GetMovementInput();
}
