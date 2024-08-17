using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAircraftMovementManager : IAircraftMovementService
{
    private float turningTimer;

    public void HandleMovement(Aircraft aircraft, float speed)
    {
        aircraft.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void HandleTurning(Aircraft aircraft, float turningTime, Vector3 startingPos, Vector3 finishPos,out bool turningFinished)
    {
        turningTimer += Time.deltaTime;

        float percentageComplete = turningTimer / turningTime;
        float newPosX =Mathf.Lerp(startingPos.x, finishPos.x, percentageComplete);
        aircraft.transform.position=new Vector3(newPosX,aircraft.transform.position.y,aircraft.transform.position.z);
        if (percentageComplete >= 1)
        {
            turningTimer = 0;
            turningFinished = true;
        }
        else
            turningFinished = false;
    }
}
