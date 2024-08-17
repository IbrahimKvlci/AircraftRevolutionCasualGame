using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager :MonoBehaviour, IInputService
{
    private PlayerInputActions inputActions;

    public static InputManager Instance { get; set; }

    private void Awake()
    {
        Instance = this;

        inputActions=new PlayerInputActions();
        inputActions.Enable();
    }

    public bool AircraftTurnLeftKeyDown()
    {
        return inputActions.Aircraft.TurningLeft.WasPressedThisFrame();
    }

    public bool AircraftTurnRightKeyDown()
    {
        return inputActions.Aircraft.TurningRight.WasPressedThisFrame();

    }
}
