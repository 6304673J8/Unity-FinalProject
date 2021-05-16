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
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""4c67a23b-7a1c-4f93-a2bc-a84ec9f58910"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""8ab9fefd-dbe9-4098-9ef1-9b8b324309a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heal"",
                    ""type"": ""Button"",
                    ""id"": ""513efc52-8118-471c-bdfa-438049355fb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""6cfc505c-f95f-4d7c-8b3a-43df0675560c"",
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
                    ""path"": ""<Gamepad>/select"",
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
                    ""id"": ""d2b57317-beec-422d-9c1c-90805646982b"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""168bd15d-4d94-4239-b0f0-c0b336043ab6"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e068188c-4e0d-42e8-a81d-705b13e15a73"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67c41e0a-d78c-40fe-97eb-01472f5591c5"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e39fc1b6-3e22-4f7e-95b5-48907e118212"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49e6b927-4441-44cb-bf41-efec8a39abda"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Heal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10f1bf82-c33f-4760-8808-75ea841a2753"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbe9a39a-fb60-4d6b-a131-ef5264873c5e"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Activate"",
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
                    ""name"": ""Next"",
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
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fec4da6d-9f95-4a75-ac0d-60030aef6e2f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Next"",
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
        m_Susana_Previous = m_Susana.FindAction("Previous", throwIfNotFound: true);
        m_Susana_Next = m_Susana.FindAction("Next", throwIfNotFound: true);
        m_Susana_Heal = m_Susana.FindAction("Heal", throwIfNotFound: true);
        m_Susana_Activate = m_Susana.FindAction("Activate", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
        // Floor
        m_Floor = asset.FindActionMap("Floor", throwIfNotFound: true);
        m_Floor_Next = m_Floor.FindAction("Next", throwIfNotFound: true);
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
    private readonly InputAction m_Susana_Previous;
    private readonly InputAction m_Susana_Next;
    private readonly InputAction m_Susana_Heal;
    private readonly InputAction m_Susana_Activate;
    public struct SusanaActions
    {
        private @PlayerInputs m_Wrapper;
        public SusanaActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Susana_Move;
        public InputAction @Lunge => m_Wrapper.m_Susana_Lunge;
        public InputAction @Earthquake => m_Wrapper.m_Susana_Earthquake;
        public InputAction @Action => m_Wrapper.m_Susana_Action;
        public InputAction @Shield => m_Wrapper.m_Susana_Shield;
        public InputAction @Previous => m_Wrapper.m_Susana_Previous;
        public InputAction @Next => m_Wrapper.m_Susana_Next;
        public InputAction @Heal => m_Wrapper.m_Susana_Heal;
        public InputAction @Activate => m_Wrapper.m_Susana_Activate;
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
                @Previous.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPrevious;
                @Previous.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPrevious;
                @Previous.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPrevious;
                @Next.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnNext;
                @Heal.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnHeal;
                @Heal.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnHeal;
                @Heal.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnHeal;
                @Activate.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnActivate;
                @Activate.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnActivate;
                @Activate.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnActivate;
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
                @Previous.started += instance.OnPrevious;
                @Previous.performed += instance.OnPrevious;
                @Previous.canceled += instance.OnPrevious;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @Heal.started += instance.OnHeal;
                @Heal.performed += instance.OnHeal;
                @Heal.canceled += instance.OnHeal;
                @Activate.started += instance.OnActivate;
                @Activate.performed += instance.OnActivate;
                @Activate.canceled += instance.OnActivate;
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
    private readonly InputAction m_Floor_Next;
    public struct FloorActions
    {
        private @PlayerInputs m_Wrapper;
        public FloorActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Next => m_Wrapper.m_Floor_Next;
        public InputActionMap Get() { return m_Wrapper.m_Floor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FloorActions set) { return set.Get(); }
        public void SetCallbacks(IFloorActions instance)
        {
            if (m_Wrapper.m_FloorActionsCallbackInterface != null)
            {
                @Next.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnNext;
            }
            m_Wrapper.m_FloorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
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
        void OnPrevious(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnHeal(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IFloorActions
    {
        void OnNext(InputAction.CallbackContext context);
    }
}
