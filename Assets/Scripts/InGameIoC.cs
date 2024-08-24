using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameIoC : MonoBehaviour
{
    public static InGameIoC Instance { get; set; }

    public IInputService InputService { get; set; }
    public IAircraftMovementService AircraftMovementService { get; set; }
    public IAircraftShootingService AircraftShootingService { get; set; }
    public IEnemyMovementService EnemyMovementService { get; set; }

    private void Awake()
    {
        Instance = this;

        InputService=InputManager.Instance;
        AircraftMovementService = new TAircraftMovementManager(InputService);
        AircraftShootingService = new AircraftShootingManager();
        EnemyMovementService= new EnemyMovementManager();
    }
}
