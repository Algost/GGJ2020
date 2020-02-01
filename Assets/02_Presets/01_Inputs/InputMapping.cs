// GENERATED AUTOMATICALLY FROM 'Assets/02_Presets/01_Inputs/InputMapping.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMapping : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMapping()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMapping"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""123819ee-6820-456b-a8c3-a3b19bb4b1a6"",
            ""actions"": [
                {
                    ""name"": ""Repair"",
                    ""type"": ""Button"",
                    ""id"": ""e450fdb3-273a-4543-ab15-d4c0f460ffe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab6a85f5-ee23-432c-95c4-6da6f1267638"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1a37bff4-db90-4503-81c7-b10dea10e970"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9810e43f-179d-4a69-bbc5-dffcdf568304"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""arrowkeys"",
                    ""id"": ""8f09facf-8ad3-4837-b4b2-5d585e3f0e73"",
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
                    ""id"": ""9a11cb7b-4b3e-4d46-8c72-e96d796450bc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0de3a74c-06a4-4c56-bb9c-e23c4711ac5e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6904145f-a389-4301-be1f-f46a272bf0c6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fe9c5a53-d89c-4fbf-9efa-9d7bd3843ad6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasdkeys"",
                    ""id"": ""4615f2f6-bf8f-4303-abb0-047de7775869"",
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
                    ""id"": ""093ef1ee-f9a9-4eb2-8d35-aef221511092"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5eeb5be6-b634-4ce1-b326-e467f75073f8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6236e839-ed1c-4e70-a2f7-58fad65b15f6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""327608b8-b454-463b-9684-b9c3186e9717"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS4"",
                    ""id"": ""e2a75cdf-02a4-4497-aa32-6f9a9b6d61d8"",
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
                    ""id"": ""af1dec22-be12-4225-bc9d-6221085a6c8e"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9050126-a1a1-450c-a0a1-e28df7bff1f9"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1b0f2d37-9c71-450e-9390-143608b68bdf"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6ef29818-0a29-449e-994e-6685cebcef66"",
                    ""path"": ""<DualShockGamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""XBOX"",
                    ""id"": ""bb9e0057-5125-4676-a46e-3c555cced2bf"",
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
                    ""id"": ""9da86441-1db9-4b75-be8c-583e46d82344"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b7f646d-edd6-43ff-8d27-75419bbe021e"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""facc74b6-aa5f-4e9d-8ac7-eb576f734511"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""499d1670-87b0-4031-8ed7-28f465b7a29a"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Tower"",
            ""id"": ""e000f97e-0fc0-4ebc-b378-a98a11eca631"",
            ""actions"": [
                {
                    ""name"": ""A1"",
                    ""type"": ""Button"",
                    ""id"": ""41530519-8a61-4e1c-8e09-a436cb7afc1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A2"",
                    ""type"": ""Button"",
                    ""id"": ""acbf6bca-fb75-4e31-9573-d9746344e7fd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A3"",
                    ""type"": ""Button"",
                    ""id"": ""4483980e-eefe-4ee4-b728-98ea490284d6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A4"",
                    ""type"": ""Button"",
                    ""id"": ""039799fc-30e4-4794-af0d-5479c30d7e38"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b86d121b-27df-45d7-92d3-0ff7c17d02c2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07109035-4f96-448d-bdca-f2b162c2f5ae"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2deba8f-7037-4d90-9838-e26ab350c51b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f684325e-8bcd-49a6-b475-31375fbdbf66"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
        },
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Repair = m_Player.FindAction("Repair", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        // Tower
        m_Tower = asset.FindActionMap("Tower", throwIfNotFound: true);
        m_Tower_A1 = m_Tower.FindAction("A1", throwIfNotFound: true);
        m_Tower_A2 = m_Tower.FindAction("A2", throwIfNotFound: true);
        m_Tower_A3 = m_Tower.FindAction("A3", throwIfNotFound: true);
        m_Tower_A4 = m_Tower.FindAction("A4", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Repair;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @InputMapping m_Wrapper;
        public PlayerActions(@InputMapping wrapper) { m_Wrapper = wrapper; }
        public InputAction @Repair => m_Wrapper.m_Player_Repair;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Repair.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRepair;
                @Repair.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRepair;
                @Repair.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRepair;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Repair.started += instance.OnRepair;
                @Repair.performed += instance.OnRepair;
                @Repair.canceled += instance.OnRepair;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Tower
    private readonly InputActionMap m_Tower;
    private ITowerActions m_TowerActionsCallbackInterface;
    private readonly InputAction m_Tower_A1;
    private readonly InputAction m_Tower_A2;
    private readonly InputAction m_Tower_A3;
    private readonly InputAction m_Tower_A4;
    public struct TowerActions
    {
        private @InputMapping m_Wrapper;
        public TowerActions(@InputMapping wrapper) { m_Wrapper = wrapper; }
        public InputAction @A1 => m_Wrapper.m_Tower_A1;
        public InputAction @A2 => m_Wrapper.m_Tower_A2;
        public InputAction @A3 => m_Wrapper.m_Tower_A3;
        public InputAction @A4 => m_Wrapper.m_Tower_A4;
        public InputActionMap Get() { return m_Wrapper.m_Tower; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TowerActions set) { return set.Get(); }
        public void SetCallbacks(ITowerActions instance)
        {
            if (m_Wrapper.m_TowerActionsCallbackInterface != null)
            {
                @A1.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnA1;
                @A1.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnA1;
                @A1.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnA1;
                @A2.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnA2;
                @A2.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnA2;
                @A2.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnA2;
                @A3.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnA3;
                @A3.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnA3;
                @A3.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnA3;
                @A4.started -= m_Wrapper.m_TowerActionsCallbackInterface.OnA4;
                @A4.performed -= m_Wrapper.m_TowerActionsCallbackInterface.OnA4;
                @A4.canceled -= m_Wrapper.m_TowerActionsCallbackInterface.OnA4;
            }
            m_Wrapper.m_TowerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A1.started += instance.OnA1;
                @A1.performed += instance.OnA1;
                @A1.canceled += instance.OnA1;
                @A2.started += instance.OnA2;
                @A2.performed += instance.OnA2;
                @A2.canceled += instance.OnA2;
                @A3.started += instance.OnA3;
                @A3.performed += instance.OnA3;
                @A3.canceled += instance.OnA3;
                @A4.started += instance.OnA4;
                @A4.performed += instance.OnA4;
                @A4.canceled += instance.OnA4;
            }
        }
    }
    public TowerActions @Tower => new TowerActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnRepair(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface ITowerActions
    {
        void OnA1(InputAction.CallbackContext context);
        void OnA2(InputAction.CallbackContext context);
        void OnA3(InputAction.CallbackContext context);
        void OnA4(InputAction.CallbackContext context);
    }
}
