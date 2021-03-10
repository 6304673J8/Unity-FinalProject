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
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""54b0a47a-78c6-481e-a1ce-212fdd7b016b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""6f582112-c314-41a6-b5ad-6bbb66291c99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=5,pressPoint=0.5)""
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ff890fc-6561-4857-bbb9-bc61d03b8af0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae1ef832-0352-48f4-ae81-bdd287c87ee4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6bcf65f-cb46-4854-a47d-aa3ed200ec07"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49b906cd-e15a-431c-825e-8ed32d15902e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""8dcf315c-5307-4594-ad17-f5e41442512c"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
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
                    ""action"": ""Move"",
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
                    ""action"": ""Move"",
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
                    ""action"": ""Move"",
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
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d7321198-f524-4c25-9436-8a0086553968"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lunge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c080034-18a2-44ab-91c7-605bfa963f5a"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense"",
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
        m_Floor_Move = m_Floor.FindAction("Move", throwIfNotFound: true);
        m_Floor_Defense = m_Floor.FindAction("Defense", throwIfNotFound: true);
        m_Floor_Shoot = m_Floor.FindAction("Shoot", throwIfNotFound: true);
        m_Floor_MousePosition = m_Floor.FindAction("MousePosition", throwIfNotFound: true);
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
    private readonly InputAction m_Floor_Move;
    private readonly InputAction m_Floor_Defense;
    private readonly InputAction m_Floor_Shoot;
    private readonly InputAction m_Floor_MousePosition;
    public struct FloorActions
    {
        private @PlayerInput m_Wrapper;
        public FloorActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Lunge => m_Wrapper.m_Floor_Lunge;
        public InputAction @Move => m_Wrapper.m_Floor_Move;
        public InputAction @Defense => m_Wrapper.m_Floor_Defense;
        public InputAction @Shoot => m_Wrapper.m_Floor_Shoot;
        public InputAction @MousePosition => m_Wrapper.m_Floor_MousePosition;
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
                @Move.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnMove;
                @Defense.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnDefense;
                @Shoot.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnShoot;
                @MousePosition.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_FloorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Lunge.started += instance.OnLunge;
                @Lunge.performed += instance.OnLunge;
                @Lunge.canceled += instance.OnLunge;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public FloorActions @Floor => new FloorActions(this);
    public interface IFloorActions
    {
        void OnLunge(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
