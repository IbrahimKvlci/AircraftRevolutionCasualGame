//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Aircraft"",
            ""id"": ""64368350-e0cf-4752-ae84-d6f800059d64"",
            ""actions"": [
                {
                    ""name"": ""TurningLeft"",
                    ""type"": ""Button"",
                    ""id"": ""2e906fb4-feac-47fd-a798-8414c8695081"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurningRight"",
                    ""type"": ""Button"",
                    ""id"": ""f8bf02a7-4857-4841-bbeb-ee8e19b08d32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurningByVector"",
                    ""type"": ""Value"",
                    ""id"": ""b5f52a6b-0715-4bce-92a7-6acc8132b0fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RocketFire"",
                    ""type"": ""Button"",
                    ""id"": ""22e04c73-3e6a-464c-ba2a-821c530cedf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0169f7d5-0974-498e-bc05-90b9e6b24321"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""754596d8-0861-4212-bb00-7e75aa2ebc0e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5ef78269-75d7-468f-8e2c-23656a1e9e0e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningByVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fb34109c-9b46-4232-8a66-5d33339ba057"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningByVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""192a5ab0-74a5-49ab-90e3-76f118c8e538"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurningByVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c98ce699-36ba-42d2-8696-c926eb644216"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RocketFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""78b38081-ce02-43b9-9052-215d8f3dfe47"",
            ""actions"": [
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""aa578e19-53fd-4bef-987d-c9cf3995c20a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""93be8eaa-b32f-42c5-ae54-6c1beed20c5a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Aircraft
        m_Aircraft = asset.FindActionMap("Aircraft", throwIfNotFound: true);
        m_Aircraft_TurningLeft = m_Aircraft.FindAction("TurningLeft", throwIfNotFound: true);
        m_Aircraft_TurningRight = m_Aircraft.FindAction("TurningRight", throwIfNotFound: true);
        m_Aircraft_TurningByVector = m_Aircraft.FindAction("TurningByVector", throwIfNotFound: true);
        m_Aircraft_RocketFire = m_Aircraft.FindAction("RocketFire", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_MousePos = m_Camera.FindAction("MousePos", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Aircraft
    private readonly InputActionMap m_Aircraft;
    private List<IAircraftActions> m_AircraftActionsCallbackInterfaces = new List<IAircraftActions>();
    private readonly InputAction m_Aircraft_TurningLeft;
    private readonly InputAction m_Aircraft_TurningRight;
    private readonly InputAction m_Aircraft_TurningByVector;
    private readonly InputAction m_Aircraft_RocketFire;
    public struct AircraftActions
    {
        private @PlayerInputActions m_Wrapper;
        public AircraftActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurningLeft => m_Wrapper.m_Aircraft_TurningLeft;
        public InputAction @TurningRight => m_Wrapper.m_Aircraft_TurningRight;
        public InputAction @TurningByVector => m_Wrapper.m_Aircraft_TurningByVector;
        public InputAction @RocketFire => m_Wrapper.m_Aircraft_RocketFire;
        public InputActionMap Get() { return m_Wrapper.m_Aircraft; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AircraftActions set) { return set.Get(); }
        public void AddCallbacks(IAircraftActions instance)
        {
            if (instance == null || m_Wrapper.m_AircraftActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AircraftActionsCallbackInterfaces.Add(instance);
            @TurningLeft.started += instance.OnTurningLeft;
            @TurningLeft.performed += instance.OnTurningLeft;
            @TurningLeft.canceled += instance.OnTurningLeft;
            @TurningRight.started += instance.OnTurningRight;
            @TurningRight.performed += instance.OnTurningRight;
            @TurningRight.canceled += instance.OnTurningRight;
            @TurningByVector.started += instance.OnTurningByVector;
            @TurningByVector.performed += instance.OnTurningByVector;
            @TurningByVector.canceled += instance.OnTurningByVector;
            @RocketFire.started += instance.OnRocketFire;
            @RocketFire.performed += instance.OnRocketFire;
            @RocketFire.canceled += instance.OnRocketFire;
        }

        private void UnregisterCallbacks(IAircraftActions instance)
        {
            @TurningLeft.started -= instance.OnTurningLeft;
            @TurningLeft.performed -= instance.OnTurningLeft;
            @TurningLeft.canceled -= instance.OnTurningLeft;
            @TurningRight.started -= instance.OnTurningRight;
            @TurningRight.performed -= instance.OnTurningRight;
            @TurningRight.canceled -= instance.OnTurningRight;
            @TurningByVector.started -= instance.OnTurningByVector;
            @TurningByVector.performed -= instance.OnTurningByVector;
            @TurningByVector.canceled -= instance.OnTurningByVector;
            @RocketFire.started -= instance.OnRocketFire;
            @RocketFire.performed -= instance.OnRocketFire;
            @RocketFire.canceled -= instance.OnRocketFire;
        }

        public void RemoveCallbacks(IAircraftActions instance)
        {
            if (m_Wrapper.m_AircraftActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAircraftActions instance)
        {
            foreach (var item in m_Wrapper.m_AircraftActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AircraftActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AircraftActions @Aircraft => new AircraftActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
    private readonly InputAction m_Camera_MousePos;
    public struct CameraActions
    {
        private @PlayerInputActions m_Wrapper;
        public CameraActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Camera_MousePos;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void AddCallbacks(ICameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
            @MousePos.started += instance.OnMousePos;
            @MousePos.performed += instance.OnMousePos;
            @MousePos.canceled += instance.OnMousePos;
        }

        private void UnregisterCallbacks(ICameraActions instance)
        {
            @MousePos.started -= instance.OnMousePos;
            @MousePos.performed -= instance.OnMousePos;
            @MousePos.canceled -= instance.OnMousePos;
        }

        public void RemoveCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IAircraftActions
    {
        void OnTurningLeft(InputAction.CallbackContext context);
        void OnTurningRight(InputAction.CallbackContext context);
        void OnTurningByVector(InputAction.CallbackContext context);
        void OnRocketFire(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnMousePos(InputAction.CallbackContext context);
    }
}
