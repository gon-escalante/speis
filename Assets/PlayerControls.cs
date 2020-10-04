// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
            ""name"": ""Gameplay"",
            ""id"": ""9f0a2032-f7db-4a5c-8cec-683276822abf"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f0725b97-ddf3-4051-a749-d79c33d3f603"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""3196de57-4efc-488f-84e5-3a3e71edc60d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""c813eff2-89eb-479c-b140-3786853bbe9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""58e1169a-ebb2-43f6-8e2d-d2cac86a48cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""81dd5bde-98f5-4379-b28d-ef8649769edc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""83a27f0e-8b43-4654-86c8-5d3c5c65d58e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""39ca337f-2579-4486-aabe-4e31fd6b0edc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""98258098-0d9a-4b64-92ef-86b6b3ec87ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b3e6f42-1636-49c4-97c7-1a2101cdf12a"",
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
                    ""id"": ""82610706-e9e1-4c20-9af2-d6c724d9f4af"",
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
                    ""id"": ""75b37435-84a1-4d77-b494-51bc8650dba6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aee31aee-055b-48d7-b186-1874c29c5173"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c90a1c0c-911f-4aed-a926-b65711b08b91"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79834948-089d-4494-8f7f-8aef5de3f0fd"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63c982a5-a602-4e27-9262-2249e8d4380c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0500987-1ac6-41fb-b25a-7941e8e534dd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
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
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        m_Gameplay_R2 = m_Gameplay.FindAction("R2", throwIfNotFound: true);
        m_Gameplay_L2 = m_Gameplay.FindAction("L2", throwIfNotFound: true);
        m_Gameplay_South = m_Gameplay.FindAction("South", throwIfNotFound: true);
        m_Gameplay_North = m_Gameplay.FindAction("North", throwIfNotFound: true);
        m_Gameplay_East = m_Gameplay.FindAction("East", throwIfNotFound: true);
        m_Gameplay_West = m_Gameplay.FindAction("West", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Rotate;
    private readonly InputAction m_Gameplay_R2;
    private readonly InputAction m_Gameplay_L2;
    private readonly InputAction m_Gameplay_South;
    private readonly InputAction m_Gameplay_North;
    private readonly InputAction m_Gameplay_East;
    private readonly InputAction m_Gameplay_West;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputAction @R2 => m_Wrapper.m_Gameplay_R2;
        public InputAction @L2 => m_Wrapper.m_Gameplay_L2;
        public InputAction @South => m_Wrapper.m_Gameplay_South;
        public InputAction @North => m_Wrapper.m_Gameplay_North;
        public InputAction @East => m_Wrapper.m_Gameplay_East;
        public InputAction @West => m_Wrapper.m_Gameplay_West;
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
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @R2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @L2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @South.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSouth;
                @North.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNorth;
                @East.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEast;
                @West.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWest;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
    }
}
