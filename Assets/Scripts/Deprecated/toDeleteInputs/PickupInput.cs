// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PickupInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PickupInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PickupInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PickupInput"",
    ""maps"": [
        {
            ""name"": ""Floor"",
            ""id"": ""2fb68856-9dc7-4a63-a0d7-37e931662a05"",
            ""actions"": [
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""6a5ed95e-a3fe-4750-9a60-27cb03b53726"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce873be4-9d62-47d1-8f26-4f555e24f21c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Floor
        m_Floor = asset.FindActionMap("Floor", throwIfNotFound: true);
        m_Floor_Pickup = m_Floor.FindAction("Pickup", throwIfNotFound: true);
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

    // Floor
    private readonly InputActionMap m_Floor;
    private IFloorActions m_FloorActionsCallbackInterface;
    private readonly InputAction m_Floor_Pickup;
    public struct FloorActions
    {
        private @PickupInput m_Wrapper;
        public FloorActions(@PickupInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pickup => m_Wrapper.m_Floor_Pickup;
        public InputActionMap Get() { return m_Wrapper.m_Floor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FloorActions set) { return set.Get(); }
        public void SetCallbacks(IFloorActions instance)
        {
            if (m_Wrapper.m_FloorActionsCallbackInterface != null)
            {
                @Pickup.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnPickup;
            }
            m_Wrapper.m_FloorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
            }
        }
    }
    public FloorActions @Floor => new FloorActions(this);
    public interface IFloorActions
    {
        void OnPickup(InputAction.CallbackContext context);
    }
}
