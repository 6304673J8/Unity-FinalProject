// GENERATED AUTOMATICALLY FROM 'Assets/Inpuctations/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Susana"",
            ""id"": ""891ab33f-ebe0-403b-8630-ca76457f4e9f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b37cd4ac-1e08-41a3-a452-37de917dcd79"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lunge"",
                    ""type"": ""Button"",
                    ""id"": ""754657a2-8b3a-4427-b34f-89ffe0cd20f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Earthquake"",
                    ""type"": ""Button"",
                    ""id"": ""8690ae30-0382-4e22-9c67-9bc4d280fe11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""16ac4f06-e0f4-45c5-9088-3736b926e01d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shield"",
                    ""type"": ""Button"",
                    ""id"": ""84289052-d486-4654-8c4d-8cbf82b59511"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7b13ffe8-d2fc-4b2a-a11a-c5ff3d58058a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""210dbe21-6e4b-4b84-a1d9-5df5103676df"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6b0e340a-f4d9-498c-8f77-93e7f9a8be5c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1f05969-1151-45b5-a629-ba26c03593a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""189b5fda-3b13-45a3-ba2c-7d011f7bf218"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""14723f91-29e3-4be2-96cb-d028bbf99391"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa42c38b-07de-42fb-b3b7-c2ad794ac57b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Lunge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a57dc1f3-c760-4a40-99d1-70566e0352cc"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Lunge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b8207e0-4ce2-4ed1-8abb-428a57196983"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Earthquake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df80f463-a1ca-4876-918f-27f73a69a1f0"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Earthquake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""644cbf95-916d-4bb2-a4ef-64c2796d9233"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aaa6f97-3970-47b9-afa2-3652c95a3e36"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b990e74-1392-4592-9499-9096a05d8e10"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4e23f70-d62e-4393-8dcf-c47378e91ef6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""1029cb5b-dcc1-494b-bcd6-c6c9b616a52a"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""09ece67f-c3b2-4039-997e-004f6ae61c40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44bd2732-6b27-4327-ba1f-a9c3a8582f07"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Floor"",
            ""id"": ""4d69438b-0283-43c0-8fe9-e7be071e2a73"",
            ""actions"": [
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""0a298377-e007-4ca1-ac26-9a218168167f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ade06ed7-9d22-4c58-aa4a-112c53bd5575"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fec4da6d-9f95-4a75-ac0d-60030aef6e2f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
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
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Susana
        m_Susana = asset.FindActionMap("Susana", throwIfNotFound: true);
        m_Susana_Move = m_Susana.FindAction("Move", throwIfNotFound: true);
        m_Susana_Lunge = m_Susana.FindAction("Lunge", throwIfNotFound: true);
        m_Susana_Earthquake = m_Susana.FindAction("Earthquake", throwIfNotFound: true);
        m_Susana_Action = m_Susana.FindAction("Action", throwIfNotFound: true);
        m_Susana_Shield = m_Susana.FindAction("Shield", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Susana
    private readonly InputActionMap m_Susana;
    private ISusanaActions m_SusanaActionsCallbackInterface;
    private readonly InputAction m_Susana_Move;
    private readonly InputAction m_Susana_Lunge;
    private readonly InputAction m_Susana_Earthquake;
    private readonly InputAction m_Susana_Action;
    private readonly InputAction m_Susana_Shield;
    public struct SusanaActions
    {
        private @PlayerInputs m_Wrapper;
        public SusanaActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Susana_Move;
        public InputAction @Lunge => m_Wrapper.m_Susana_Lunge;
        public InputAction @Earthquake => m_Wrapper.m_Susana_Earthquake;
        public InputAction @Action => m_Wrapper.m_Susana_Action;
        public InputAction @Shield => m_Wrapper.m_Susana_Shield;
        public InputActionMap Get() { return m_Wrapper.m_Susana; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SusanaActions set) { return set.Get(); }
        public void SetCallbacks(ISusanaActions instance)
        {
            if (m_Wrapper.m_SusanaActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMove;
                @Lunge.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Lunge.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Lunge.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Earthquake.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Action.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnAction;
                @Shield.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnShield;
                @Shield.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnShield;
                @Shield.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnShield;
            }
            m_Wrapper.m_SusanaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Lunge.started += instance.OnLunge;
                @Lunge.performed += instance.OnLunge;
                @Lunge.canceled += instance.OnLunge;
                @Earthquake.started += instance.OnEarthquake;
                @Earthquake.performed += instance.OnEarthquake;
                @Earthquake.canceled += instance.OnEarthquake;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Shield.started += instance.OnShield;
                @Shield.performed += instance.OnShield;
                @Shield.canceled += instance.OnShield;
            }
        }
    }
    public SusanaActions @Susana => new SusanaActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @PlayerInputs m_Wrapper;
        public UIActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Floor
    private readonly InputActionMap m_Floor;
    private IFloorActions m_FloorActionsCallbackInterface;
    private readonly InputAction m_Floor_Pickup;
    public struct FloorActions
    {
        private @PlayerInputs m_Wrapper;
        public FloorActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
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
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ISusanaActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLunge(InputAction.CallbackContext context);
        void OnEarthquake(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IFloorActions
    {
        void OnPickup(InputAction.CallbackContext context);
    }
}
