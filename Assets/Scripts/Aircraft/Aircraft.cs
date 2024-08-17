using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    [field:SerializeField] public AircraftSO AircraftSO {  get; set; }

    public IAircraftState AircraftFreezingState { get; set; }
    public IAircraftState AircraftMovingState { get; set; }
    public IAircraftState AircraftRevolutionState { get; set; }

    private IAircraftStateService _aircraftStateService;
    private IAircraftMovementService _aircraftMovementService;
    private IInputService _inputService;

    private void Awake()
    {
        _inputService=InGameIoC.Instance.InputService;
        _aircraftStateService = new AircraftStateManager();
        _aircraftMovementService=InGameIoC.Instance.AircraftMovementService;

        AircraftFreezingState = new AircraftFreezingState(this, _aircraftStateService);
        AircraftMovingState=new AircraftMovingState(this, _aircraftStateService,_aircraftMovementService,_inputService);
        AircraftRevolutionState=new AircraftRevolutionState(this, _aircraftStateService);
    }

    private void Start()
    {
        _aircraftStateService.Initialize(AircraftFreezingState);
    }

    private void Update()
    {
        _aircraftStateService.CurrentAircraftState.UpdateState();   
    }
}
