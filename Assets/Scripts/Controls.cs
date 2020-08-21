// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

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
            ""name"": ""Battle"",
            ""id"": ""d91b38ca-65f6-4774-ae9d-2b234daa043a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""68328de9-6558-4937-880d-312d7e84c460"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""eabcdd18-b86d-4c20-85fb-903324e29100"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""e3f227a1-2bf5-4c33-8132-c3a73c26931b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""1d36cdd0-f78b-4dcf-8f0f-11c17cf3f94b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9611b323-752a-4bea-a5fe-0994a8602f43"",
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
                    ""id"": ""9d49c44c-dcd0-4a85-94b0-5fb0b2a0f78d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""32a92b59-b389-4996-82f8-eed02a6086fc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""80039475-1834-4e9e-974a-22ee2ee22525"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb5c33a5-9aa2-4cec-afa6-3b8b3189a238"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2bb25c57-2024-43f2-8f3c-ff4b8ced9c5b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6184c280-4425-4ede-9845-895b512edc3b"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf6693d-73af-4433-8fe5-493138522c43"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""7fce0f1b-f97f-4833-8831-39730f7d6ac5"",
            ""actions"": [
                {
                    ""name"": ""DisplayBattle"",
                    ""type"": ""Button"",
                    ""id"": ""1c72f4fc-1a91-41eb-b635-33633ae20d9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f0fcc950-af47-4454-b9cb-be2118576de6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""DisplayBattle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": []
        }
    ]
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_Move = m_Battle.FindAction("Move", throwIfNotFound: true);
        m_Battle_Select = m_Battle.FindAction("Select", throwIfNotFound: true);
        m_Battle_Special = m_Battle.FindAction("Special", throwIfNotFound: true);
        m_Battle_Cancel = m_Battle.FindAction("Cancel", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_DisplayBattle = m_Debug.FindAction("DisplayBattle", throwIfNotFound: true);
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

    // Battle
    private readonly InputActionMap m_Battle;
    private IBattleActions m_BattleActionsCallbackInterface;
    private readonly InputAction m_Battle_Move;
    private readonly InputAction m_Battle_Select;
    private readonly InputAction m_Battle_Special;
    private readonly InputAction m_Battle_Cancel;
    public struct BattleActions
    {
        private @Controls m_Wrapper;
        public BattleActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Battle_Move;
        public InputAction @Select => m_Wrapper.m_Battle_Select;
        public InputAction @Special => m_Wrapper.m_Battle_Special;
        public InputAction @Cancel => m_Wrapper.m_Battle_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
        public void SetCallbacks(IBattleActions instance)
        {
            if (m_Wrapper.m_BattleActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Select.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnSelect;
                @Special.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnSpecial;
                @Cancel.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public BattleActions @Battle => new BattleActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_DisplayBattle;
    public struct DebugActions
    {
        private @Controls m_Wrapper;
        public DebugActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DisplayBattle => m_Wrapper.m_Debug_DisplayBattle;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @DisplayBattle.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisplayBattle;
                @DisplayBattle.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisplayBattle;
                @DisplayBattle.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisplayBattle;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DisplayBattle.started += instance.OnDisplayBattle;
                @DisplayBattle.performed += instance.OnDisplayBattle;
                @DisplayBattle.canceled += instance.OnDisplayBattle;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    private int m_DefaultSchemeIndex = -1;
    public InputControlScheme DefaultScheme
    {
        get
        {
            if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
            return asset.controlSchemes[m_DefaultSchemeIndex];
        }
    }
    public interface IBattleActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnDisplayBattle(InputAction.CallbackContext context);
    }
}
