// GENERATED AUTOMATICALLY FROM 'Assets/Inpuctations/GameController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameController"",
    ""maps"": [
        {
            ""name"": ""Susana"",
            ""id"": ""ac69ab6d-8a08-49ba-8c09-f1f75586f51b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d4738247-0a7a-46e5-9c03-33585700bb1c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lunge"",
                    ""type"": ""Button"",
                    ""id"": ""ebe1d0f6-e9e2-4766-a3f0-c0e217a35cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""15c3b4d5-804a-4ac5-a703-25bb92aeb40b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Earthquake"",
                    ""type"": ""Button"",
                    ""id"": ""e1f48eaa-5a2c-4321-a8d6-3ba6482bdbcf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pick"",
                    ""type"": ""Button"",
                    ""id"": ""b7f28c3c-8e93-4903-9717-5743e331a0b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""4c963e51-da22-4c9f-8970-9bc0eaf7035e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""615edf52-b05a-4c33-931b-9767dcde362a"",
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
                    ""id"": ""08c03815-7454-49af-b795-63547b5b73e6"",
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
                    ""id"": ""65b64ff2-0edf-47af-af84-2384ba13aae0"",
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
                    ""id"": ""78cc9238-5899-421f-a0fd-b9d5765cc3ca"",
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
                    ""id"": ""18b96a98-05e5-4eb0-996a-25e2b482a2e7"",
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
                    ""id"": ""966e7cd6-5797-434b-aae1-5cd7c7b25749"",
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
                    ""id"": ""c6bb8eed-056b-4a7a-b31a-8f42d13f2b0a"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b65c78f-c0ae-4684-88de-b3d7155041c4"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Earthquake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5faf324d-c8fd-47dd-a7c8-b39caa944b59"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92c7868f-5b07-4cc1-a774-ce7e5bd86791"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Use"",
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
            ""devices"": []
        }
    ]
}");
        // Susana
        m_Susana = asset.FindActionMap("Susana", throwIfNotFound: true);
        m_Susana_Move = m_Susana.FindAction("Move", throwIfNotFound: true);
        m_Susana_Lunge = m_Susana.FindAction("Lunge", throwIfNotFound: true);
        m_Susana_Defense = m_Susana.FindAction("Defense", throwIfNotFound: true);
        m_Susana_Earthquake = m_Susana.FindAction("Earthquake", throwIfNotFound: true);
        m_Susana_Pick = m_Susana.FindAction("Pick", throwIfNotFound: true);
        m_Susana_Use = m_Susana.FindAction("Use", throwIfNotFound: true);
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
    private readonly InputAction m_Susana_Defense;
    private readonly InputAction m_Susana_Earthquake;
    private readonly InputAction m_Susana_Pick;
    private readonly InputAction m_Susana_Use;
    public struct SusanaActions
    {
        private @GameController m_Wrapper;
        public SusanaActions(@GameController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Susana_Move;
        public InputAction @Lunge => m_Wrapper.m_Susana_Lunge;
        public InputAction @Defense => m_Wrapper.m_Susana_Defense;
        public InputAction @Earthquake => m_Wrapper.m_Susana_Earthquake;
        public InputAction @Pick => m_Wrapper.m_Susana_Pick;
        public InputAction @Use => m_Wrapper.m_Susana_Use;
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
                @Defense.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnDefense;
                @Earthquake.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Pick.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPick;
                @Pick.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPick;
                @Pick.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnPick;
                @Use.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnUse;
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
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Earthquake.started += instance.OnEarthquake;
                @Earthquake.performed += instance.OnEarthquake;
                @Earthquake.canceled += instance.OnEarthquake;
                @Pick.started += instance.OnPick;
                @Pick.performed += instance.OnPick;
                @Pick.canceled += instance.OnPick;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
            }
        }
    }
    public SusanaActions @Susana => new SusanaActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface ISusanaActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLunge(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnEarthquake(InputAction.CallbackContext context);
        void OnPick(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
    }
}
