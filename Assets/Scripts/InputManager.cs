using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager :MonoBehaviour, IInputService
{
    private PlayerInputActions inputActions;

    public static InputManager Instance { get; set; }

    private Vector2 _mousePosition;

    private void Awake()
    {
        Instance = this;

        inputActions=new PlayerInputActions();
        inputActions.Enable();

        inputActions.Camera.MousePos.performed += MousePos_performed;


    }

    private void MousePos_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _mousePosition = obj.ReadValue<Vector2>();
    }

    public bool AircraftTurnLeftKeyDown()
    {
        return inputActions.Aircraft.TurningLeft.WasPressedThisFrame();
    }

    public bool AircraftTurnRightKeyDown()
    {
        return inputActions.Aircraft.TurningRight.WasPressedThisFrame();

    }

    public Vector3 GetMousePositionOnATarget()
    {
        Vector3 mousePos = _mousePosition;
        Vector3 lastPos = mousePos;

        mousePos.z = Camera.main.nearClipPlane;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            lastPos = hitInfo.point;
        }

        return lastPos;
    }

    public Vector3 GetMousePositionOnWorldPoint()
    {
        return Camera.main.ScreenToWorldPoint(_mousePosition);
    }

    public Vector2 GetMovementInput()
    {
        return inputActions.Aircraft.TurningByVector.ReadValue<Vector2>();
    }

    public bool RocketFireButtonKey()
    {
        return inputActions.Aircraft.RocketFire.IsPressed();
    }
}
