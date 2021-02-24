// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""28f165a1-41cc-41fd-84b2-86057acb15d5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d0918781-1552-4bf3-8523-e8c255db9687"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Value"",
                    ""id"": ""b97930fd-52c2-47bc-95e0-3749ed63a45d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9dbd6a0f-5b8b-4cee-ac63-721c0a4086e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shift2"",
                    ""type"": ""Value"",
                    ""id"": ""2d82d993-4880-4e48-b478-53a4f6fd7c1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartButton"",
                    ""type"": ""PassThrough"",
                    ""id"": ""65192774-f1bf-43bc-a39e-c06138bc37d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""94b4a07c-687b-4ba8-87e8-f7163e23115e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""087c64bb-79fc-41f2-8d08-4da3e7753a61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""efb130e2-3c8e-4ea9-ad08-759939f2e20b"",
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
                    ""id"": ""4000f686-51f3-4222-982e-10ae4d116b2d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""71714f95-653b-4156-a5c8-da1819a659fd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9beb84fc-0a64-4c46-ab57-a3439fa958cb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c52ac0ef-9666-463a-9168-263135f49d88"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4b4be75c-b188-471e-b82c-cc13b0979eb6"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2942548c-2e01-4c4e-82ef-db3982906dfd"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62f8682a-e323-4acd-96b1-25d2f00cb4fd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb579f70-ea89-467f-bc60-d7978cb551dd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Shift = m_Gameplay.FindAction("Shift", throwIfNotFound: true);
        m_Gameplay_Move2 = m_Gameplay.FindAction("Move2", throwIfNotFound: true);
        m_Gameplay_Shift2 = m_Gameplay.FindAction("Shift2", throwIfNotFound: true);
        m_Gameplay_RestartButton = m_Gameplay.FindAction("RestartButton", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Shift;
    private readonly InputAction m_Gameplay_Move2;
    private readonly InputAction m_Gameplay_Shift2;
    private readonly InputAction m_Gameplay_RestartButton;
    public struct GameplayActions
    {
        private @PlayerActions m_Wrapper;
        public GameplayActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Shift => m_Wrapper.m_Gameplay_Shift;
        public InputAction @Move2 => m_Wrapper.m_Gameplay_Move2;
        public InputAction @Shift2 => m_Wrapper.m_Gameplay_Shift2;
        public InputAction @RestartButton => m_Wrapper.m_Gameplay_RestartButton;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Shift.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Move2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove2;
                @Move2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove2;
                @Move2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove2;
                @Shift2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift2;
                @Shift2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift2;
                @Shift2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift2;
                @RestartButton.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestartButton;
                @RestartButton.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestartButton;
                @RestartButton.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRestartButton;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
                @Move2.started += instance.OnMove2;
                @Move2.performed += instance.OnMove2;
                @Move2.canceled += instance.OnMove2;
                @Shift2.started += instance.OnShift2;
                @Shift2.performed += instance.OnShift2;
                @Shift2.canceled += instance.OnShift2;
                @RestartButton.started += instance.OnRestartButton;
                @RestartButton.performed += instance.OnRestartButton;
                @RestartButton.canceled += instance.OnRestartButton;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
        void OnMove2(InputAction.CallbackContext context);
        void OnShift2(InputAction.CallbackContext context);
        void OnRestartButton(InputAction.CallbackContext context);
    }
}
