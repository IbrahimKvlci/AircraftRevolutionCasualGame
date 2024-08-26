using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAircraftMovementManager : IAircraftMovementService
{
    private float turningTimer;

    private IInputService _intputService;

    public TAircraftMovementManager(IInputService inputService)
    {
        _intputService=inputService;
    }

    public void HandleMovement(Aircraft aircraft, float speed)
    {
        if (!aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.Right)&&_intputService.GetMovementInput().x>0)    
        {
            aircraft.transform.Translate(new Vector3(_intputService.GetMovementInput().x,0,0) * Time.deltaTime * speed);
        }
        if (!aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.Left) && _intputService.GetMovementInput().x < 0)
        {
            aircraft.transform.Translate(new Vector3(_intputService.GetMovementInput().x, 0, 0) * Time.deltaTime * speed);
        }
        if(!aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.forward) && _intputService.GetMovementInput().y > 0)
            aircraft.transform.Translate(new Vector3(0,0,_intputService.GetMovementInput().y)*Time.deltaTime*speed);
        if (!aircraft.AircraftTriggerController.CheckIsThereBarrier(AircraftTriggerController.BarrierLocationEnum.back) && _intputService.GetMovementInput().y < 0)
            aircraft.transform.Translate(new Vector3(0, 0, _intputService.GetMovementInput().y) * Time.deltaTime * speed);
    }

    public void HandleTurningOnce(Aircraft aircraft, float turningTime, Vector3 startingPos, Vector3 finishPos,out bool turningFinished)
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
