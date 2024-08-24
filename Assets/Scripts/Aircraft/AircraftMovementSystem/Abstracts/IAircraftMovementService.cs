using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAircraftMovementService 
{
    void HandleMovement(Aircraft aircraft,float speed);

    void HandleTurningOnce(Aircraft aircraft,float turningTime,Vector3 startingPos,Vector3 finishPos,out bool turningFinished);
    void HandleTurning(Aircraft aircraft, float speed);
}
