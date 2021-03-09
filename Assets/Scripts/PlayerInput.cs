// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Floor"",
            ""id"": ""0989f67f-8947-4487-bdbc-969ec1149cea"",
            ""actions"": [
                {
                    ""name"": ""Lunge"",
                    ""type"": ""Button"",
                    ""id"": ""4fe83857-fbf0-43b3-b54f-b41cf6c05cf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Walking"",
                    ""type"": ""PassThrough"",
                    ""id"": ""54b0a47a-78c6-481e-a1ce-212fdd7b016b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8dcf315c-5307-4594-ad17-f5e41442512c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d9745a7e-b2ff-4066-bf4b-448ab04c1c4a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""402e7898-42be-4ce8-831a-4aa26d9539f0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e10a3016-fecf-421d-8208-0c810ec65cb0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b16ea5e-cadd-4408-9aaf-64fd9ac3c59a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d7321198-f524-4c25-9436-8a0086553968"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lunge"",
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
        m_Floor_Lunge = m_Floor.FindAction("Lunge", throwIfNotFound: true);
        m_Floor_Walking = m_Floor.FindAction("Walking", throwIfNotFound: true);
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
    private readonly InputAction m_Floor_Lunge;
    private readonly InputAction m_Floor_Walking;
    public struct FloorActions
    {
        private @PlayerInput m_Wrapper;
        public FloorActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Lunge => m_Wrapper.m_Floor_Lunge;
        public InputAction @Walking => m_Wrapper.m_Floor_Walking;
        public InputActionMap Get() { return m_Wrapper.m_Floor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FloorActions set) { return set.Get(); }
        public void SetCallbacks(IFloorActions instance)
        {
            if (m_Wrapper.m_FloorActionsCallbackInterface != null)
            {
                @Lunge.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnLunge;
                @Lunge.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnLunge;
                @Lunge.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnLunge;
                @Walking.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnWalking;
            }
            m_Wrapper.m_FloorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Lunge.started += instance.OnLunge;
                @Lunge.performed += instance.OnLunge;
                @Lunge.canceled += instance.OnLunge;
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
            }
        }
    }
    public FloorActions @Floor => new FloorActions(this);
    public interface IFloorActions
    {
        void OnLunge(InputAction.CallbackContext context);
        void OnWalking(InputAction.CallbackContext context);
    }
}
