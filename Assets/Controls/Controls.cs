// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MainCharacters"",
            ""id"": ""2ff4ca68-6171-4eb8-90b5-a2bf15fd648c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4f1f971c-b072-4418-bbff-c11c5648b52c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""93c68701-bb7c-4039-bd44-21d44b0dd9cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlatformJump"",
                    ""type"": ""Button"",
                    ""id"": ""ff972943-69a1-4121-828d-244f142cb245"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""24436da1-c5b2-4478-9e03-d954b8a787e8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""baa49109-91cc-4a87-9dac-d766e5fa080e"",
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
                    ""id"": ""9cccfeb0-cc83-40e0-98b1-541891a14738"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepade"",
                    ""id"": ""408657c2-b13a-4b28-8c2e-bc4a02ab98f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""78ecc2f0-7b83-4915-8784-97822056b9bf"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepade"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e9c87e7b-f63a-45ee-bf6c-b42b6873357d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepade"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f310cbb-01a6-4603-a46b-28180bb0d924"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c38444e-f002-4c2c-8b3f-02f4514a8b83"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepade"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edaa415a-7cb7-40b3-9417-5ea75f1d7786"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PlatformJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da292c19-c391-4720-939f-fa39843eff31"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Gamepade"",
                    ""action"": ""PlatformJump"",
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
        },
        {
            ""name"": ""Gamepade"",
            ""bindingGroup"": ""Gamepade"",
            ""devices"": []
        }
    ]
}");
        // MainCharacters
        m_MainCharacters = asset.FindActionMap("MainCharacters", throwIfNotFound: true);
        m_MainCharacters_Move = m_MainCharacters.FindAction("Move", throwIfNotFound: true);
        m_MainCharacters_Jump = m_MainCharacters.FindAction("Jump", throwIfNotFound: true);
        m_MainCharacters_PlatformJump = m_MainCharacters.FindAction("PlatformJump", throwIfNotFound: true);
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

    // MainCharacters
    private readonly InputActionMap m_MainCharacters;
    private IMainCharactersActions m_MainCharactersActionsCallbackInterface;
    private readonly InputAction m_MainCharacters_Move;
    private readonly InputAction m_MainCharacters_Jump;
    private readonly InputAction m_MainCharacters_PlatformJump;
    public struct MainCharactersActions
    {
        private @Controls m_Wrapper;
        public MainCharactersActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MainCharacters_Move;
        public InputAction @Jump => m_Wrapper.m_MainCharacters_Jump;
        public InputAction @PlatformJump => m_Wrapper.m_MainCharacters_PlatformJump;
        public InputActionMap Get() { return m_Wrapper.m_MainCharacters; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainCharactersActions set) { return set.Get(); }
        public void SetCallbacks(IMainCharactersActions instance)
        {
            if (m_Wrapper.m_MainCharactersActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnJump;
                @PlatformJump.started -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnPlatformJump;
                @PlatformJump.performed -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnPlatformJump;
                @PlatformJump.canceled -= m_Wrapper.m_MainCharactersActionsCallbackInterface.OnPlatformJump;
            }
            m_Wrapper.m_MainCharactersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @PlatformJump.started += instance.OnPlatformJump;
                @PlatformJump.performed += instance.OnPlatformJump;
                @PlatformJump.canceled += instance.OnPlatformJump;
            }
        }
    }
    public MainCharactersActions @MainCharacters => new MainCharactersActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadeSchemeIndex = -1;
    public InputControlScheme GamepadeScheme
    {
        get
        {
            if (m_GamepadeSchemeIndex == -1) m_GamepadeSchemeIndex = asset.FindControlSchemeIndex("Gamepade");
            return asset.controlSchemes[m_GamepadeSchemeIndex];
        }
    }
    public interface IMainCharactersActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPlatformJump(InputAction.CallbackContext context);
    }
}
