using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftTriggerController : MonoBehaviour
{


    [SerializeField] private Aircraft aircraft;
    [SerializeField] private float barrierRaycastDistance;
    [field:SerializeField] public LayerMask BarrierLayerMask { get; private set; }

    public enum BarrierLocationEnum
    {
        Left,
        Right,
    }

    public bool CheckIsThereBarrier(BarrierLocationEnum barrierLocationEnum)
    {
        Vector3 direction=Vector3.zero;
        if (barrierLocationEnum == BarrierLocationEnum.Left)
            direction = Vector3.left;
        else if(barrierLocationEnum == BarrierLocationEnum.Right)
            direction = Vector3.right;

        return Physics.Raycast(aircraft.transform.position, direction, barrierRaycastDistance);
    }
}
