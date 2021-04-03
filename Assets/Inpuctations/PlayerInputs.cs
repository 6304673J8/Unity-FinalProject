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
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
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
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""210dbe21-6e4b-4b84-a1d9-5df5103676df"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6b0e340a-f4d9-498c-8f77-93e7f9a8be5c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1f05969-1151-45b5-a629-ba26c03593a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""189b5fda-3b13-45a3-ba2c-7d011f7bf218"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""id"": ""9b8207e0-4ce2-4ed1-8abb-428a57196983"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Earthquake"",
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
        }
    ]
}");
        // Susana
        m_Susana = asset.FindActionMap("Susana", throwIfNotFound: true);
        m_Susana_Movement = m_Susana.FindAction("Movement", throwIfNotFound: true);
        m_Susana_Lunge = m_Susana.FindAction("Lunge", throwIfNotFound: true);
        m_Susana_Earthquake = m_Susana.FindAction("Earthquake", throwIfNotFound: true);
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
    private readonly InputAction m_Susana_Movement;
    private readonly InputAction m_Susana_Lunge;
    private readonly InputAction m_Susana_Earthquake;
    public struct SusanaActions
    {
        private @PlayerInputs m_Wrapper;
        public SusanaActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Susana_Movement;
        public InputAction @Lunge => m_Wrapper.m_Susana_Lunge;
        public InputAction @Earthquake => m_Wrapper.m_Susana_Earthquake;
        public InputActionMap Get() { return m_Wrapper.m_Susana; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SusanaActions set) { return set.Get(); }
        public void SetCallbacks(ISusanaActions instance)
        {
            if (m_Wrapper.m_SusanaActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnMovement;
                @Lunge.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Lunge.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Lunge.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnLunge;
                @Earthquake.started -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.performed -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
                @Earthquake.canceled -= m_Wrapper.m_SusanaActionsCallbackInterface.OnEarthquake;
            }
            m_Wrapper.m_SusanaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Lunge.started += instance.OnLunge;
                @Lunge.performed += instance.OnLunge;
                @Lunge.canceled += instance.OnLunge;
                @Earthquake.started += instance.OnEarthquake;
                @Earthquake.performed += instance.OnEarthquake;
                @Earthquake.canceled += instance.OnEarthquake;
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
        void OnMovement(InputAction.CallbackContext context);
        void OnLunge(InputAction.CallbackContext context);
        void OnEarthquake(InputAction.CallbackContext context);
    }
}
