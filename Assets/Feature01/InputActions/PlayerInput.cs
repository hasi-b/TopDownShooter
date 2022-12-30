//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Feature01/InputActions/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""6724d60f-2448-46e0-9345-353796cb3935"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f16a318a-848e-4614-acba-6b037b9f6380"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""dfbf5e46-6f19-4c92-ba34-40774ec725da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8a4b639d-bc1a-408a-bae8-2d3a08bc6334"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GetDirection"",
                    ""type"": ""Value"",
                    ""id"": ""d08d0451-773d-48cf-8ed7-831290cbbb87"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ec7c545c-9d70-465a-9690-e7d2ef21ad90"",
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
                    ""id"": ""45b40a0c-ffab-47dc-a216-1f34a22e1124"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aadda743-101a-46bf-9148-52bfdf628f49"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3b96904b-2100-4c43-bda4-49d6a039f26a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2b264204-f1b9-48ca-b2ed-dbae13a94566"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ccc2c836-3cac-4d78-895d-fb6ca7fdb55a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a461bd4f-637a-4afc-856d-0219b9fd50ec"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd106e57-4b92-4985-8090-82a5ed3b8ee6"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9a71db0-e9be-4b26-b52b-9ac71f1ffed8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca46d57f-2bdc-4924-bb95-34c7af8dc83b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GetDirection"",
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
        // PlayerOnFoot
        m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
        m_PlayerOnFoot_Movement = m_PlayerOnFoot.FindAction("Movement", throwIfNotFound: true);
        m_PlayerOnFoot_Fire = m_PlayerOnFoot.FindAction("Fire", throwIfNotFound: true);
        m_PlayerOnFoot_MousePosition = m_PlayerOnFoot.FindAction("MousePosition", throwIfNotFound: true);
        m_PlayerOnFoot_GetDirection = m_PlayerOnFoot.FindAction("GetDirection", throwIfNotFound: true);
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

    // PlayerOnFoot
    private readonly InputActionMap m_PlayerOnFoot;
    private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
    private readonly InputAction m_PlayerOnFoot_Movement;
    private readonly InputAction m_PlayerOnFoot_Fire;
    private readonly InputAction m_PlayerOnFoot_MousePosition;
    private readonly InputAction m_PlayerOnFoot_GetDirection;
    public struct PlayerOnFootActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerOnFootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerOnFoot_Movement;
        public InputAction @Fire => m_Wrapper.m_PlayerOnFoot_Fire;
        public InputAction @MousePosition => m_Wrapper.m_PlayerOnFoot_MousePosition;
        public InputAction @GetDirection => m_Wrapper.m_PlayerOnFoot_GetDirection;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOnFootActions instance)
        {
            if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnFire;
                @MousePosition.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnMousePosition;
                @GetDirection.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnGetDirection;
                @GetDirection.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnGetDirection;
                @GetDirection.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnGetDirection;
            }
            m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @GetDirection.started += instance.OnGetDirection;
                @GetDirection.performed += instance.OnGetDirection;
                @GetDirection.canceled += instance.OnGetDirection;
            }
        }
    }
    public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
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
    public interface IPlayerOnFootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnGetDirection(InputAction.CallbackContext context);
    }
}
