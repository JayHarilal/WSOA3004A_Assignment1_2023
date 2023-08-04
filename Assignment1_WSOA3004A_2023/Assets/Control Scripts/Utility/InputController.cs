//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Control Scripts/Utility/InputController.inputactions
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

public partial class @InputController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Player Control"",
            ""id"": ""fefe4e0f-4e12-43a2-96fc-c58d4efd19bf"",
            ""actions"": [
                {
                    ""name"": ""Directional Input"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f41ea2c-7074-48d8-bb65-e5d7f19d9826"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""ea2474ed-e4cb-4c48-875d-b00ff4106171"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MedPunch"",
                    ""type"": ""Button"",
                    ""id"": ""ca93b75a-0db6-468a-bf8c-c51267657d1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HeavyPunch"",
                    ""type"": ""Button"",
                    ""id"": ""a46e3de7-4df7-4495-bca4-2e6de8363606"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightKick"",
                    ""type"": ""Button"",
                    ""id"": ""9ede87b9-7981-4d6a-a400-b5a09f4cc218"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MedKick"",
                    ""type"": ""Button"",
                    ""id"": ""7e0bf975-3b49-42ac-b78a-ba5babb157e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HeavyKick"",
                    ""type"": ""Button"",
                    ""id"": ""948d0a05-6f33-4025-a964-261c4564e3ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""3cdec6b6-2ddd-4642-b95b-7d857405a8ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Directions"",
                    ""id"": ""eb0cb559-46cc-43a3-b3f8-c696c3cba0af"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6abf07d-9a31-4f9a-9836-1920dde96d70"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24f03e40-c659-431c-8c93-ca00a6df53b6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""855bfe81-0dbb-4888-90bc-288281b3e49a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f46fa038-4ae8-4209-b517-c44577d0d705"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Directions (Stick)"",
                    ""id"": ""c5d51c53-272a-4a3b-ba66-315be38ade45"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6a95d71-a208-42f5-b88b-206f99b02b47"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50eb2da4-fd65-4b25-b2ba-f161ad2ae8e8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d5f7aa9d-7e3d-4a04-9abd-e313e6074335"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bbaeab79-6e69-45f6-81e7-d6d1e75ea0a6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Directions (DPad)"",
                    ""id"": ""1bf2ba70-085d-4bf5-98cc-980d345e2db8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Input"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8c6cc08c-11a0-4355-8957-4d12e5c72b7f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""71481a99-2de5-4405-9b33-c9bedc211d73"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0d5e9bb4-cf9b-4784-8f8a-fdf02679a041"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e9a12a9b-2ca7-4ff4-89ef-79a42fcd591c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""Directional Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""940ddcd7-b6b3-45ff-8911-acec3fc95cf1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""MedPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96cf18b3-8c77-4510-a7df-d42bcb9646df"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MedPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f59d6642-7222-4156-92b6-822b55830c0f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""LightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5409ce67-e49e-4552-890d-0cef80976bbd"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9f401d9-2048-489e-8c05-f0f567df5164"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""HeavyPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8881bbb-3592-4323-b65a-29f9cbc1ea83"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HeavyPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c46e6016-6fff-4842-8ff3-605802776acc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""LightKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d23ac307-2538-4be5-b903-cf3f7209fe04"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LightKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3453bdaf-4134-4dfe-af7d-2ff874e6967c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""MedKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e5a83d0-5a1a-4509-a236-3e3840b38f53"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MedKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b744a20d-ddc9-4695-aa01-e86394fd3420"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""HeavyKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d465995c-e923-430c-8793-6e90c6feb827"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HeavyKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f93ed1d-d10f-4e0e-a112-b6db2e1e5add"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc490ef8-b339-40b9-a93f-c9da71aa7127"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pad"",
                    ""action"": ""QuitGame"",
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
            ""name"": ""Pad"",
            ""bindingGroup"": ""Pad"",
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
        // Player Control
        m_PlayerControl = asset.FindActionMap("Player Control", throwIfNotFound: true);
        m_PlayerControl_DirectionalInput = m_PlayerControl.FindAction("Directional Input", throwIfNotFound: true);
        m_PlayerControl_LightPunch = m_PlayerControl.FindAction("LightPunch", throwIfNotFound: true);
        m_PlayerControl_MedPunch = m_PlayerControl.FindAction("MedPunch", throwIfNotFound: true);
        m_PlayerControl_HeavyPunch = m_PlayerControl.FindAction("HeavyPunch", throwIfNotFound: true);
        m_PlayerControl_LightKick = m_PlayerControl.FindAction("LightKick", throwIfNotFound: true);
        m_PlayerControl_MedKick = m_PlayerControl.FindAction("MedKick", throwIfNotFound: true);
        m_PlayerControl_HeavyKick = m_PlayerControl.FindAction("HeavyKick", throwIfNotFound: true);
        m_PlayerControl_QuitGame = m_PlayerControl.FindAction("QuitGame", throwIfNotFound: true);
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

    // Player Control
    private readonly InputActionMap m_PlayerControl;
    private List<IPlayerControlActions> m_PlayerControlActionsCallbackInterfaces = new List<IPlayerControlActions>();
    private readonly InputAction m_PlayerControl_DirectionalInput;
    private readonly InputAction m_PlayerControl_LightPunch;
    private readonly InputAction m_PlayerControl_MedPunch;
    private readonly InputAction m_PlayerControl_HeavyPunch;
    private readonly InputAction m_PlayerControl_LightKick;
    private readonly InputAction m_PlayerControl_MedKick;
    private readonly InputAction m_PlayerControl_HeavyKick;
    private readonly InputAction m_PlayerControl_QuitGame;
    public struct PlayerControlActions
    {
        private @InputController m_Wrapper;
        public PlayerControlActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @DirectionalInput => m_Wrapper.m_PlayerControl_DirectionalInput;
        public InputAction @LightPunch => m_Wrapper.m_PlayerControl_LightPunch;
        public InputAction @MedPunch => m_Wrapper.m_PlayerControl_MedPunch;
        public InputAction @HeavyPunch => m_Wrapper.m_PlayerControl_HeavyPunch;
        public InputAction @LightKick => m_Wrapper.m_PlayerControl_LightKick;
        public InputAction @MedKick => m_Wrapper.m_PlayerControl_MedKick;
        public InputAction @HeavyKick => m_Wrapper.m_PlayerControl_HeavyKick;
        public InputAction @QuitGame => m_Wrapper.m_PlayerControl_QuitGame;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Add(instance);
            @DirectionalInput.started += instance.OnDirectionalInput;
            @DirectionalInput.performed += instance.OnDirectionalInput;
            @DirectionalInput.canceled += instance.OnDirectionalInput;
            @LightPunch.started += instance.OnLightPunch;
            @LightPunch.performed += instance.OnLightPunch;
            @LightPunch.canceled += instance.OnLightPunch;
            @MedPunch.started += instance.OnMedPunch;
            @MedPunch.performed += instance.OnMedPunch;
            @MedPunch.canceled += instance.OnMedPunch;
            @HeavyPunch.started += instance.OnHeavyPunch;
            @HeavyPunch.performed += instance.OnHeavyPunch;
            @HeavyPunch.canceled += instance.OnHeavyPunch;
            @LightKick.started += instance.OnLightKick;
            @LightKick.performed += instance.OnLightKick;
            @LightKick.canceled += instance.OnLightKick;
            @MedKick.started += instance.OnMedKick;
            @MedKick.performed += instance.OnMedKick;
            @MedKick.canceled += instance.OnMedKick;
            @HeavyKick.started += instance.OnHeavyKick;
            @HeavyKick.performed += instance.OnHeavyKick;
            @HeavyKick.canceled += instance.OnHeavyKick;
            @QuitGame.started += instance.OnQuitGame;
            @QuitGame.performed += instance.OnQuitGame;
            @QuitGame.canceled += instance.OnQuitGame;
        }

        private void UnregisterCallbacks(IPlayerControlActions instance)
        {
            @DirectionalInput.started -= instance.OnDirectionalInput;
            @DirectionalInput.performed -= instance.OnDirectionalInput;
            @DirectionalInput.canceled -= instance.OnDirectionalInput;
            @LightPunch.started -= instance.OnLightPunch;
            @LightPunch.performed -= instance.OnLightPunch;
            @LightPunch.canceled -= instance.OnLightPunch;
            @MedPunch.started -= instance.OnMedPunch;
            @MedPunch.performed -= instance.OnMedPunch;
            @MedPunch.canceled -= instance.OnMedPunch;
            @HeavyPunch.started -= instance.OnHeavyPunch;
            @HeavyPunch.performed -= instance.OnHeavyPunch;
            @HeavyPunch.canceled -= instance.OnHeavyPunch;
            @LightKick.started -= instance.OnLightKick;
            @LightKick.performed -= instance.OnLightKick;
            @LightKick.canceled -= instance.OnLightKick;
            @MedKick.started -= instance.OnMedKick;
            @MedKick.performed -= instance.OnMedKick;
            @MedKick.canceled -= instance.OnMedKick;
            @HeavyKick.started -= instance.OnHeavyKick;
            @HeavyKick.performed -= instance.OnHeavyKick;
            @HeavyKick.canceled -= instance.OnHeavyKick;
            @QuitGame.started -= instance.OnQuitGame;
            @QuitGame.performed -= instance.OnQuitGame;
            @QuitGame.canceled -= instance.OnQuitGame;
        }

        public void RemoveCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_PadSchemeIndex = -1;
    public InputControlScheme PadScheme
    {
        get
        {
            if (m_PadSchemeIndex == -1) m_PadSchemeIndex = asset.FindControlSchemeIndex("Pad");
            return asset.controlSchemes[m_PadSchemeIndex];
        }
    }
    public interface IPlayerControlActions
    {
        void OnDirectionalInput(InputAction.CallbackContext context);
        void OnLightPunch(InputAction.CallbackContext context);
        void OnMedPunch(InputAction.CallbackContext context);
        void OnHeavyPunch(InputAction.CallbackContext context);
        void OnLightKick(InputAction.CallbackContext context);
        void OnMedKick(InputAction.CallbackContext context);
        void OnHeavyKick(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
    }
}
