// GENERATED AUTOMATICALLY FROM 'Assets/e-Assets/Inputs/Test Controls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class TestControls : IInputActionCollection
{
    private InputActionAsset asset;
    public TestControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Test Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""78d37dff-b916-4ceb-a8ff-2e79f7c496c4"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""c238b9a7-ce4e-48c9-ae71-514d3f95ec44"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7b976640-9343-41c2-b4f1-57f105b265cf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""821bfa82-acbc-4ccb-b668-f89fdff427c2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grapple"",
                    ""type"": ""Button"",
                    ""id"": ""9dadf57f-7d9d-4a4c-89e1-d987dd81216b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rock"",
                    ""type"": ""Button"",
                    ""id"": ""153823d7-4215-4f09-8104-666a2db8e893"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Paper"",
                    ""type"": ""Button"",
                    ""id"": ""2b523ea7-331f-46c5-85de-64adf80ee5d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scissor"",
                    ""type"": ""Button"",
                    ""id"": ""ed6ccdb3-efc1-4180-8960-df5319b26f04"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d96c055-cba3-455c-85a6-ae4baee0b4e0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78116988-e7bb-4732-a021-e36b225aa2dd"",
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
                    ""id"": ""53d3a6ff-94de-4df0-828e-4753e6c56baa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""536b2d34-5d08-44f0-bb74-3cd41ee892e1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grapple"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d028bd81-b1bd-4801-93bd-7cf6baf49c53"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67da0b62-c1a2-472d-ae1d-da8c00e33594"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ca513c9-cf07-4f56-8d0d-04bc08b72a4d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Run = m_Gameplay.GetAction("Run");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_Rotate = m_Gameplay.GetAction("Rotate");
        m_Gameplay_Grapple = m_Gameplay.GetAction("Grapple");
        m_Gameplay_Rock = m_Gameplay.GetAction("Rock");
        m_Gameplay_Paper = m_Gameplay.GetAction("Paper");
        m_Gameplay_Scissor = m_Gameplay.GetAction("Scissor");
    }

    ~TestControls()
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
    private readonly InputAction m_Gameplay_Run;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    private readonly InputAction m_Gameplay_Grapple;
    private readonly InputAction m_Gameplay_Rock;
    private readonly InputAction m_Gameplay_Paper;
    private readonly InputAction m_Gameplay_Scissor;
    public struct GameplayActions
    {
        private TestControls m_Wrapper;
        public GameplayActions(TestControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Gameplay_Run;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputAction @Grapple => m_Wrapper.m_Gameplay_Grapple;
        public InputAction @Rock => m_Wrapper.m_Gameplay_Rock;
        public InputAction @Paper => m_Wrapper.m_Gameplay_Paper;
        public InputAction @Scissor => m_Wrapper.m_Gameplay_Scissor;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Run.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                Run.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                Run.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                Grapple.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrapple;
                Grapple.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrapple;
                Grapple.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrapple;
                Rock.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRock;
                Rock.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRock;
                Rock.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRock;
                Paper.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPaper;
                Paper.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPaper;
                Paper.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPaper;
                Scissor.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScissor;
                Scissor.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScissor;
                Scissor.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScissor;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Run.started += instance.OnRun;
                Run.performed += instance.OnRun;
                Run.canceled += instance.OnRun;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                Grapple.started += instance.OnGrapple;
                Grapple.performed += instance.OnGrapple;
                Grapple.canceled += instance.OnGrapple;
                Rock.started += instance.OnRock;
                Rock.performed += instance.OnRock;
                Rock.canceled += instance.OnRock;
                Paper.started += instance.OnPaper;
                Paper.performed += instance.OnPaper;
                Paper.canceled += instance.OnPaper;
                Scissor.started += instance.OnScissor;
                Scissor.performed += instance.OnScissor;
                Scissor.canceled += instance.OnScissor;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnGrapple(InputAction.CallbackContext context);
        void OnRock(InputAction.CallbackContext context);
        void OnPaper(InputAction.CallbackContext context);
        void OnScissor(InputAction.CallbackContext context);
    }
}
