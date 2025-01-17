// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""CameraActions"",
            ""id"": ""53f9055d-34e3-4f12-b122-9b62836327a9"",
            ""actions"": [
                {
                    ""name"": ""Pan"",
                    ""type"": ""PassThrough"",
                    ""id"": ""537e747a-c21b-4287-837f-156eb4e3b67f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e460b0ee-09a0-472b-810e-75ebac99f5ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""ae487af2-ff4e-4acc-bc3b-1ea36108c7fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""fd12e003-cd36-412e-82c9-631eb0efb28d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e5433fe0-36b3-48f0-9af9-a9fa3e728923"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3d4abb51-7b57-4290-8a12-cf42d116f27e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9844a694-89e9-4f8a-8a64-996acf8c2d47"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31da790e-f0ed-4d95-ba96-b60b625fa3ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""121c3e10-73b4-4f2d-b485-1b7577ad3507"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""edc0a0fc-9e39-4db1-bdb8-29e95f3908c7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61dcc666-e1f7-4916-ac9d-be08c9166570"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df0749d5-cad5-4002-a3e5-f13a84985c4f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""607b0331-e17d-4672-8c28-69696f341ad6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""351302cf-6a7a-4515-8200-7b023841d018"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e5e0944-49a2-4d81-83e9-64dfc0e09001"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraActions
        m_CameraActions = asset.FindActionMap("CameraActions", throwIfNotFound: true);
        m_CameraActions_Pan = m_CameraActions.FindAction("Pan", throwIfNotFound: true);
        m_CameraActions_RotateLeft = m_CameraActions.FindAction("RotateLeft", throwIfNotFound: true);
        m_CameraActions_RotateRight = m_CameraActions.FindAction("RotateRight", throwIfNotFound: true);
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

    // CameraActions
    private readonly InputActionMap m_CameraActions;
    private ICameraActionsActions m_CameraActionsActionsCallbackInterface;
    private readonly InputAction m_CameraActions_Pan;
    private readonly InputAction m_CameraActions_RotateLeft;
    private readonly InputAction m_CameraActions_RotateRight;
    public struct CameraActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public CameraActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pan => m_Wrapper.m_CameraActions_Pan;
        public InputAction @RotateLeft => m_Wrapper.m_CameraActions_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_CameraActions_RotateRight;
        public InputActionMap Get() { return m_Wrapper.m_CameraActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActionsActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActionsActions instance)
        {
            if (m_Wrapper.m_CameraActionsActionsCallbackInterface != null)
            {
                @Pan.started -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnPan;
                @Pan.performed -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnPan;
                @Pan.canceled -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnPan;
                @RotateLeft.started -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_CameraActionsActionsCallbackInterface.OnRotateRight;
            }
            m_Wrapper.m_CameraActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pan.started += instance.OnPan;
                @Pan.performed += instance.OnPan;
                @Pan.canceled += instance.OnPan;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
            }
        }
    }
    public CameraActionsActions @CameraActions => new CameraActionsActions(this);
    public interface ICameraActionsActions
    {
        void OnPan(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
    }
}
