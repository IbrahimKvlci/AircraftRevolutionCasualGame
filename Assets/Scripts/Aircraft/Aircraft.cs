using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    public event EventHandler OnLevelChanged;

    [field:SerializeField] public AircraftSO AircraftSO {  get; set; }
    [field:SerializeField] public AircraftTriggerController AircraftTriggerController { get; set; }
    [field:SerializeField] public AircraftIdleShootingController AircraftIdleShootingController { get; set; }


    private int _level;
    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
            OnLevelChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public float Speed { get; set; }

    public IAircraftState AircraftFreezingState { get; set; }
    public IAircraftState AircraftMovingState { get; set; }
    public IAircraftState AircraftRevolutionState { get; set; }

    private IAircraftStateService _aircraftStateService;
    private IAircraftMovementService _aircraftMovementService;

    private void Awake()
    {
        _aircraftStateService = new AircraftStateManager();
        _aircraftMovementService=InGameIoC.Instance.AircraftMovementService;

        AircraftFreezingState = new AircraftFreezingState(this, _aircraftStateService);
        AircraftMovingState=new AircraftMovingState(this, _aircraftStateService,_aircraftMovementService);
        AircraftRevolutionState=new AircraftRevolutionState(this, _aircraftStateService);
    }

    private void Start()
    {
        _aircraftStateService.Initialize(AircraftFreezingState);

        Level = 1;
        Speed = AircraftSO.speed;
    }

    private void Update()
    {
        _aircraftStateService.CurrentAircraftState.UpdateState();   
    }

    public void AddLevel(int level)
    {
        Level += level;
        Speed += level*AircraftSO.speedMultiplier;
    }

}
