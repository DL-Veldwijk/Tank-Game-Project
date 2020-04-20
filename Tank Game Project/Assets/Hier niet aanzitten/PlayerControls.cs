// GENERATED AUTOMATICALLY FROM 'Assets/Hier niet aanzitten/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""InputControler"",
            ""id"": ""15837110-7322-4f65-8838-63aa46ba552d"",
            ""actions"": [
                {
                    ""name"": ""LeftCirclePad"",
                    ""type"": ""Value"",
                    ""id"": ""1b338013-560b-4103-ba52-0d368943fe5c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightCirclePad"",
                    ""type"": ""Value"",
                    ""id"": ""ba565d82-3e5f-4f13-a06b-802f8a0bd04b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftBumper"",
                    ""type"": ""Button"",
                    ""id"": ""45b4c35c-bea5-4ecb-95ea-ab7103cf66f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightBumper"",
                    ""type"": ""Button"",
                    ""id"": ""9c84ee51-0294-4994-abf4-11e65a3f029a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""1a837bd2-c6f1-460f-a5fb-10de2639db87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""6f81d2c4-da61-4d09-85da-d52a87edb4b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3cbfcaa8-e92e-4ff3-8334-c21d39fcd8b2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b6b0905-9861-41ae-b836-f5bb121f3984"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightBumper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54f109af-c1a5-4d86-aa20-c452dc0a07ef"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d311c75-236a-4dea-ba92-a33f8a503b31"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""573ac029-9bdc-4a6f-bf35-2b83c8fbc241"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftCirclePad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51ac2258-86e6-42b8-869a-4695d001c456"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightCirclePad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InputControler
        m_InputControler = asset.FindActionMap("InputControler", throwIfNotFound: true);
        m_InputControler_LeftCirclePad = m_InputControler.FindAction("LeftCirclePad", throwIfNotFound: true);
        m_InputControler_RightCirclePad = m_InputControler.FindAction("RightCirclePad", throwIfNotFound: true);
        m_InputControler_LeftBumper = m_InputControler.FindAction("LeftBumper", throwIfNotFound: true);
        m_InputControler_RightBumper = m_InputControler.FindAction("RightBumper", throwIfNotFound: true);
        m_InputControler_LeftTrigger = m_InputControler.FindAction("LeftTrigger", throwIfNotFound: true);
        m_InputControler_RightTrigger = m_InputControler.FindAction("RightTrigger", throwIfNotFound: true);
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

    // InputControler
    private readonly InputActionMap m_InputControler;
    private IInputControlerActions m_InputControlerActionsCallbackInterface;
    private readonly InputAction m_InputControler_LeftCirclePad;
    private readonly InputAction m_InputControler_RightCirclePad;
    private readonly InputAction m_InputControler_LeftBumper;
    private readonly InputAction m_InputControler_RightBumper;
    private readonly InputAction m_InputControler_LeftTrigger;
    private readonly InputAction m_InputControler_RightTrigger;
    public struct InputControlerActions
    {
        private @PlayerControls m_Wrapper;
        public InputControlerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftCirclePad => m_Wrapper.m_InputControler_LeftCirclePad;
        public InputAction @RightCirclePad => m_Wrapper.m_InputControler_RightCirclePad;
        public InputAction @LeftBumper => m_Wrapper.m_InputControler_LeftBumper;
        public InputAction @RightBumper => m_Wrapper.m_InputControler_RightBumper;
        public InputAction @LeftTrigger => m_Wrapper.m_InputControler_LeftTrigger;
        public InputAction @RightTrigger => m_Wrapper.m_InputControler_RightTrigger;
        public InputActionMap Get() { return m_Wrapper.m_InputControler; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputControlerActions set) { return set.Get(); }
        public void SetCallbacks(IInputControlerActions instance)
        {
            if (m_Wrapper.m_InputControlerActionsCallbackInterface != null)
            {
                @LeftCirclePad.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftCirclePad;
                @LeftCirclePad.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftCirclePad;
                @LeftCirclePad.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftCirclePad;
                @RightCirclePad.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightCirclePad;
                @RightCirclePad.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightCirclePad;
                @RightCirclePad.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightCirclePad;
                @LeftBumper.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftBumper;
                @LeftBumper.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftBumper;
                @LeftBumper.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftBumper;
                @RightBumper.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightBumper;
                @RightBumper.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightBumper;
                @RightBumper.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightBumper;
                @LeftTrigger.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnLeftTrigger;
                @RightTrigger.started -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_InputControlerActionsCallbackInterface.OnRightTrigger;
            }
            m_Wrapper.m_InputControlerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftCirclePad.started += instance.OnLeftCirclePad;
                @LeftCirclePad.performed += instance.OnLeftCirclePad;
                @LeftCirclePad.canceled += instance.OnLeftCirclePad;
                @RightCirclePad.started += instance.OnRightCirclePad;
                @RightCirclePad.performed += instance.OnRightCirclePad;
                @RightCirclePad.canceled += instance.OnRightCirclePad;
                @LeftBumper.started += instance.OnLeftBumper;
                @LeftBumper.performed += instance.OnLeftBumper;
                @LeftBumper.canceled += instance.OnLeftBumper;
                @RightBumper.started += instance.OnRightBumper;
                @RightBumper.performed += instance.OnRightBumper;
                @RightBumper.canceled += instance.OnRightBumper;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
            }
        }
    }
    public InputControlerActions @InputControler => new InputControlerActions(this);
    public interface IInputControlerActions
    {
        void OnLeftCirclePad(InputAction.CallbackContext context);
        void OnRightCirclePad(InputAction.CallbackContext context);
        void OnLeftBumper(InputAction.CallbackContext context);
        void OnRightBumper(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
    }
}
