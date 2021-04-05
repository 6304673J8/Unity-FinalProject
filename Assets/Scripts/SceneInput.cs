// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/SceneInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SceneInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SceneInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SceneInput"",
    ""maps"": [
        {
            ""name"": ""Scene"",
            ""id"": ""022e57c7-2f6d-4ec4-b53f-7ba39f782170"",
            ""actions"": [
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""eaf174c8-45ac-4446-bacc-804c8c8c2188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""36fe6d5e-f22d-42e2-ab46-59a99183ebb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""285d5a74-7643-41cd-8871-08b5c4532dde"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce9c45b1-2b9c-4e75-9062-2e3332369e55"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Scene
        m_Scene = asset.FindActionMap("Scene", throwIfNotFound: true);
        m_Scene_Previous = m_Scene.FindAction("Previous", throwIfNotFound: true);
        m_Scene_Next = m_Scene.FindAction("Next", throwIfNotFound: true);
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

    // Scene
    private readonly InputActionMap m_Scene;
    private ISceneActions m_SceneActionsCallbackInterface;
    private readonly InputAction m_Scene_Previous;
    private readonly InputAction m_Scene_Next;
    public struct SceneActions
    {
        private @SceneInput m_Wrapper;
        public SceneActions(@SceneInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Previous => m_Wrapper.m_Scene_Previous;
        public InputAction @Next => m_Wrapper.m_Scene_Next;
        public InputActionMap Get() { return m_Wrapper.m_Scene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SceneActions set) { return set.Get(); }
        public void SetCallbacks(ISceneActions instance)
        {
            if (m_Wrapper.m_SceneActionsCallbackInterface != null)
            {
                @Previous.started -= m_Wrapper.m_SceneActionsCallbackInterface.OnPrevious;
                @Previous.performed -= m_Wrapper.m_SceneActionsCallbackInterface.OnPrevious;
                @Previous.canceled -= m_Wrapper.m_SceneActionsCallbackInterface.OnPrevious;
                @Next.started -= m_Wrapper.m_SceneActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_SceneActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_SceneActionsCallbackInterface.OnNext;
            }
            m_Wrapper.m_SceneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Previous.started += instance.OnPrevious;
                @Previous.performed += instance.OnPrevious;
                @Previous.canceled += instance.OnPrevious;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
            }
        }
    }
    public SceneActions @Scene => new SceneActions(this);
    public interface ISceneActions
    {
        void OnPrevious(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
    }
}
