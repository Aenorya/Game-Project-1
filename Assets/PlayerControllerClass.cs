//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerController.inputactions
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

public partial class @PlayerControllerClass : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllerClass()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""93e9bc02-c73e-4df1-8d67-24a663c0f13b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9ba6a773-6839-43cf-9ab7-6ae5ca6fed9c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""8933f31a-2d3d-44a8-8333-a7c0eb44581f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""48af2034-8b7a-47ea-a10d-9720824229ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack01"",
                    ""type"": ""Button"",
                    ""id"": ""94a5dbc3-6b54-4ad2-b397-4591d94c481d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause Menu"",
                    ""type"": ""Button"",
                    ""id"": ""96646a3e-7710-4104-9c22-4d88c46396e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseSyringe"",
                    ""type"": ""Button"",
                    ""id"": ""4c6cb595-d9db-4f92-bfcb-af390cf279fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HealthTest"",
                    ""type"": ""Button"",
                    ""id"": ""8c69997a-22fc-43ac-b555-8e27d38e5e58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0df79792-ad0e-4337-a66a-e2be10d1859d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b23c000-0d6c-4cf3-b042-2ebc42a71164"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c2fae7e-7431-44be-ab5a-d9edaf0a80da"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""974595a8-d7cc-4607-93f7-3ce258c41532"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec86691d-ea9b-4c52-91be-ea8a377c9c72"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e38b6bd-23b6-424b-bb08-68486bd2063d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a2b9337-39ae-43a9-b869-fe616e9911eb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c76181f6-a888-444e-9c0e-77836262674a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16c97407-a9ef-4a3d-b1a8-f773ffe82d81"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD/ZQSD"",
                    ""id"": ""08a5a513-f4f0-4048-97dd-e11a068b2ad6"",
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
                    ""id"": ""a268f74c-11ee-4b23-9882-83b08a893591"",
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
                    ""id"": ""55f3f722-f051-4dc3-83db-f25857427192"",
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
                    ""id"": ""3bd8697b-e941-4963-89d3-618dd648ac68"",
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
                    ""id"": ""5271f51a-d50a-443c-8ab5-1fe4fc6116a6"",
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
                    ""id"": ""e4b72366-1530-40d7-9abc-4bb1c5d788ad"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseSyringe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c89cdac5-8460-446d-a594-eeb4a4e2e148"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseSyringe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0c8b685-6e97-4223-9ab9-34e183423ecd"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HealthTest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""43bbcfa7-9e50-4b90-acd1-34215b56eaaf"",
            ""actions"": [
                {
                    ""name"": ""Validation"",
                    ""type"": ""Button"",
                    ""id"": ""1b610d3c-4f13-4195-b861-7cd6edd9d8ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Nope/Return"",
                    ""type"": ""Button"",
                    ""id"": ""34bea90a-71bb-4521-8444-4fc060e2c689"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99296d27-0d8a-410f-a5c8-36715b0179b9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a5e4f94-e045-4a2c-a5f8-41a612153156"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da1ec7d0-640c-4800-88be-680173776996"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""708bf038-dfc4-44d5-b35a-8f748c37fcea"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Nope/Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12e6c928-86f5-4310-8bcd-c5964270871c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Nope/Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Attack01 = m_Player.FindAction("Attack01", throwIfNotFound: true);
        m_Player_PauseMenu = m_Player.FindAction("Pause Menu", throwIfNotFound: true);
        m_Player_UseSyringe = m_Player.FindAction("UseSyringe", throwIfNotFound: true);
        m_Player_HealthTest = m_Player.FindAction("HealthTest", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Validation = m_Menu.FindAction("Validation", throwIfNotFound: true);
        m_Menu_NopeReturn = m_Menu.FindAction("Nope/Return", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Attack01;
    private readonly InputAction m_Player_PauseMenu;
    private readonly InputAction m_Player_UseSyringe;
    private readonly InputAction m_Player_HealthTest;
    public struct PlayerActions
    {
        private @PlayerControllerClass m_Wrapper;
        public PlayerActions(@PlayerControllerClass wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Attack01 => m_Wrapper.m_Player_Attack01;
        public InputAction @PauseMenu => m_Wrapper.m_Player_PauseMenu;
        public InputAction @UseSyringe => m_Wrapper.m_Player_UseSyringe;
        public InputAction @HealthTest => m_Wrapper.m_Player_HealthTest;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Attack01.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack01;
                @Attack01.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack01;
                @Attack01.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack01;
                @PauseMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseMenu;
                @UseSyringe.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseSyringe;
                @UseSyringe.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseSyringe;
                @UseSyringe.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseSyringe;
                @HealthTest.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHealthTest;
                @HealthTest.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHealthTest;
                @HealthTest.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHealthTest;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack01.started += instance.OnAttack01;
                @Attack01.performed += instance.OnAttack01;
                @Attack01.canceled += instance.OnAttack01;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @UseSyringe.started += instance.OnUseSyringe;
                @UseSyringe.performed += instance.OnUseSyringe;
                @UseSyringe.canceled += instance.OnUseSyringe;
                @HealthTest.started += instance.OnHealthTest;
                @HealthTest.performed += instance.OnHealthTest;
                @HealthTest.canceled += instance.OnHealthTest;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Validation;
    private readonly InputAction m_Menu_NopeReturn;
    public struct MenuActions
    {
        private @PlayerControllerClass m_Wrapper;
        public MenuActions(@PlayerControllerClass wrapper) { m_Wrapper = wrapper; }
        public InputAction @Validation => m_Wrapper.m_Menu_Validation;
        public InputAction @NopeReturn => m_Wrapper.m_Menu_NopeReturn;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Validation.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidation;
                @Validation.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidation;
                @Validation.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidation;
                @NopeReturn.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNopeReturn;
                @NopeReturn.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNopeReturn;
                @NopeReturn.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNopeReturn;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Validation.started += instance.OnValidation;
                @Validation.performed += instance.OnValidation;
                @Validation.canceled += instance.OnValidation;
                @NopeReturn.started += instance.OnNopeReturn;
                @NopeReturn.performed += instance.OnNopeReturn;
                @NopeReturn.canceled += instance.OnNopeReturn;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack01(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnUseSyringe(InputAction.CallbackContext context);
        void OnHealthTest(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnValidation(InputAction.CallbackContext context);
        void OnNopeReturn(InputAction.CallbackContext context);
    }
}
