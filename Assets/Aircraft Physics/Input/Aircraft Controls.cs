//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Aircraft Physics/Input/Aircraft Controls.inputactions
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

public partial class @AircraftControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @AircraftControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Aircraft Controls"",
    ""maps"": [
        {
            ""name"": ""Aircraft"",
            ""id"": ""1d6318fe-ab16-4f8c-bb43-26bc1db02d3e"",
            ""actions"": [
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""767768d4-00ac-432e-a35d-738dea8a068f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""039886a5-36f3-4df1-be42-ee5078337ab3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""72af519f-5190-4929-ab7e-6554df57a579"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57eb2f42-453f-4f59-88c7-cd067e8f9bf4"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40cf2a6a-2f58-4655-8fee-452e6972cd2e"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7727d48-f925-41ba-9ebb-2d9f6c62f211"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
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
        m_Aircraft_Pitch = m_Aircraft.FindAction("Pitch", throwIfNotFound: true);
        m_Aircraft_Roll = m_Aircraft.FindAction("Roll", throwIfNotFound: true);
        m_Aircraft_Yaw = m_Aircraft.FindAction("Yaw", throwIfNotFound: true);
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
    private readonly InputAction m_Aircraft_Pitch;
    private readonly InputAction m_Aircraft_Roll;
    private readonly InputAction m_Aircraft_Yaw;
    public struct AircraftActions
    {
        private @AircraftControls m_Wrapper;
        public AircraftActions(@AircraftControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pitch => m_Wrapper.m_Aircraft_Pitch;
        public InputAction @Roll => m_Wrapper.m_Aircraft_Roll;
        public InputAction @Yaw => m_Wrapper.m_Aircraft_Yaw;
        public InputActionMap Get() { return m_Wrapper.m_Aircraft; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AircraftActions set) { return set.Get(); }
        public void AddCallbacks(IAircraftActions instance)
        {
            if (instance == null || m_Wrapper.m_AircraftActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AircraftActionsCallbackInterfaces.Add(instance);
            @Pitch.started += instance.OnPitch;
            @Pitch.performed += instance.OnPitch;
            @Pitch.canceled += instance.OnPitch;
            @Roll.started += instance.OnRoll;
            @Roll.performed += instance.OnRoll;
            @Roll.canceled += instance.OnRoll;
            @Yaw.started += instance.OnYaw;
            @Yaw.performed += instance.OnYaw;
            @Yaw.canceled += instance.OnYaw;
        }

        private void UnregisterCallbacks(IAircraftActions instance)
        {
            @Pitch.started -= instance.OnPitch;
            @Pitch.performed -= instance.OnPitch;
            @Pitch.canceled -= instance.OnPitch;
            @Roll.started -= instance.OnRoll;
            @Roll.performed -= instance.OnRoll;
            @Roll.canceled -= instance.OnRoll;
            @Yaw.started -= instance.OnYaw;
            @Yaw.performed -= instance.OnYaw;
            @Yaw.canceled -= instance.OnYaw;
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
    public interface IAircraftActions
    {
        void OnPitch(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
    }
}
