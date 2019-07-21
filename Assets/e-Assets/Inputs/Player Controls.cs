// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Player Controls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""GameplayMap"",
            ""id"": ""add6acdb-a9a0-48e5-8fb8-051bff1174b5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""95bcaf9a-8171-421c-a1cc-95ef67599f10"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2c951b21-6057-416b-8688-ee894dd0e938"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Wave"",
                    ""type"": ""Button"",
                    ""id"": ""6f4bdc80-f954-4c01-af41-d7b303bc84b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""f6cd3530-cf3e-4c7f-98f9-efdfca276a25"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchMode"",
                    ""type"": ""Button"",
                    ""id"": ""17f13af7-b4e5-42a7-8221-98f0b210c420"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6102b3e2-52be-4832-abf9-5f50224a73a6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff387ccf-7b16-478b-8ce4-41a373b3d7f3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c4af001-1ca7-4173-a9c1-4b821f7bcbfe"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2349b529-d91e-42c6-bbe4-a7ad284ee2fb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4500447-8fec-4aac-9134-46b90d646994"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayMap
        m_GameplayMap = asset.GetActionMap("GameplayMap");
        m_GameplayMap_Move = m_GameplayMap.GetAction("Move");
        m_GameplayMap_Jump = m_GameplayMap.GetAction("Jump");
        m_GameplayMap_Wave = m_GameplayMap.GetAction("Wave");
        m_GameplayMap_PickUp = m_GameplayMap.GetAction("PickUp");
        m_GameplayMap_SwitchMode = m_GameplayMap.GetAction("SwitchMode");
    }

    ~PlayerControls()
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

    // GameplayMap
    private readonly InputActionMap m_GameplayMap;
    private IGameplayMapActions m_GameplayMapActionsCallbackInterface;
    private readonly InputAction m_GameplayMap_Move;
    private readonly InputAction m_GameplayMap_Jump;
    private readonly InputAction m_GameplayMap_Wave;
    private readonly InputAction m_GameplayMap_PickUp;
    private readonly InputAction m_GameplayMap_SwitchMode;
    public struct GameplayMapActions
    {
        private PlayerControls m_Wrapper;
        public GameplayMapActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GameplayMap_Move;
        public InputAction @Jump => m_Wrapper.m_GameplayMap_Jump;
        public InputAction @Wave => m_Wrapper.m_GameplayMap_Wave;
        public InputAction @PickUp => m_Wrapper.m_GameplayMap_PickUp;
        public InputAction @SwitchMode => m_Wrapper.m_GameplayMap_SwitchMode;
        public InputActionMap Get() { return m_Wrapper.m_GameplayMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayMapActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayMapActions instance)
        {
            if (m_Wrapper.m_GameplayMapActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnMove;
                Jump.started -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnJump;
                Wave.started -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnWave;
                Wave.performed -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnWave;
                Wave.canceled -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnWave;
                PickUp.started -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnPickUp;
                PickUp.performed -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnPickUp;
                PickUp.canceled -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnPickUp;
                SwitchMode.started -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnSwitchMode;
                SwitchMode.performed -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnSwitchMode;
                SwitchMode.canceled -= m_Wrapper.m_GameplayMapActionsCallbackInterface.OnSwitchMode;
            }
            m_Wrapper.m_GameplayMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Wave.started += instance.OnWave;
                Wave.performed += instance.OnWave;
                Wave.canceled += instance.OnWave;
                PickUp.started += instance.OnPickUp;
                PickUp.performed += instance.OnPickUp;
                PickUp.canceled += instance.OnPickUp;
                SwitchMode.started += instance.OnSwitchMode;
                SwitchMode.performed += instance.OnSwitchMode;
                SwitchMode.canceled += instance.OnSwitchMode;
            }
        }
    }
    public GameplayMapActions @GameplayMap => new GameplayMapActions(this);
    public interface IGameplayMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnWave(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnSwitchMode(InputAction.CallbackContext context);
    }
}
