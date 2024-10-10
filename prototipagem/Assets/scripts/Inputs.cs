//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/scripts/Inputs.inputactions
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

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ae6302c8-d64d-46cd-800b-f3aa1ecb27c4"",
            ""actions"": [
                {
                    ""name"": ""Pular"",
                    ""type"": ""Button"",
                    ""id"": ""a67fc990-996e-4820-a13f-d18168aaa02c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Andar"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cd0c5588-ea11-4da5-86ad-1ba59492e010"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Empurrar"",
                    ""type"": ""Button"",
                    ""id"": ""ba7c1749-f94a-4dc1-a1a0-c300c651fbbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Agachar"",
                    ""type"": ""Button"",
                    ""id"": ""801770fe-73e8-4d88-b825-463691ffe414"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""puxar"",
                    ""type"": ""Button"",
                    ""id"": ""c76eaa09-962e-41fa-9c1d-1948ada2e114"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SuperPulo"",
                    ""type"": ""Button"",
                    ""id"": ""cdaf935e-766f-4a29-ba40-8f4fda8f8714"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""braço"",
                    ""type"": ""Button"",
                    ""id"": ""ef90adb7-4e95-4bfb-9c1c-925b4a874a04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Puxar "",
                    ""type"": ""Button"",
                    ""id"": ""85f9c095-1d29-4628-b5e7-0826ce886bb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Esticar Braço"",
                    ""type"": ""Button"",
                    ""id"": ""f1afc097-4fc8-4626-88fb-76ceed938ade"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""passarfase"",
                    ""type"": ""Button"",
                    ""id"": ""fdfd0cea-7961-49fe-a7fd-3152311d9ef2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""retrocederfase"",
                    ""type"": ""Button"",
                    ""id"": ""b4065a3b-eb4d-437a-b1b9-2fc32ba848b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""990b7dc3-c568-4d40-8d09-47b26c67338a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pular"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58cdafaa-3777-4dee-90d6-c60fa70aec7d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Empurrar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a729f2eb-d9b1-42d2-9962-c9ecd1493e87"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agachar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cd214fe6-6d0a-4782-aa83-5821fcf5fc5a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Andar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a2962a19-35af-456c-88d2-f6884f914728"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Andar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f56d1ba9-d7f9-470d-b493-14dae41993d5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Andar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7ef6f08-42d7-4354-8b2d-ceec08557afe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Andar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7ea2bfb-75af-414d-8bcb-e315def7a83b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Andar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e558831a-ac4e-45e5-81ca-6e0c30b1782d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""puxar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b25387ec-6ec1-410c-9f77-60ff78e1b6c4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuperPulo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68479b30-3985-4a7d-bca8-3445c3901e13"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""braço"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26d8656d-3e7f-4791-9cdd-573e920f4b65"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Puxar "",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea2f7a2-108e-4137-b733-b9ca842cfc1b"",
                    ""path"": ""<Keyboard>/#(J)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esticar Braço"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5399290d-8179-46a3-81f8-b23a44a2b076"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""passarfase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d44e91b-c2d3-4901-a329-88e5bcecdb63"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""retrocederfase"",
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
        m_Player_Pular = m_Player.FindAction("Pular", throwIfNotFound: true);
        m_Player_Andar = m_Player.FindAction("Andar", throwIfNotFound: true);
        m_Player_Empurrar = m_Player.FindAction("Empurrar", throwIfNotFound: true);
        m_Player_Agachar = m_Player.FindAction("Agachar", throwIfNotFound: true);
        m_Player_puxar = m_Player.FindAction("puxar", throwIfNotFound: true);
        m_Player_SuperPulo = m_Player.FindAction("SuperPulo", throwIfNotFound: true);
        m_Player_braço = m_Player.FindAction("braço", throwIfNotFound: true);
        m_Player_Puxar = m_Player.FindAction("Puxar ", throwIfNotFound: true);
        m_Player_EsticarBraço = m_Player.FindAction("Esticar Braço", throwIfNotFound: true);
        m_Player_passarfase = m_Player.FindAction("passarfase", throwIfNotFound: true);
        m_Player_retrocederfase = m_Player.FindAction("retrocederfase", throwIfNotFound: true);
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Pular;
    private readonly InputAction m_Player_Andar;
    private readonly InputAction m_Player_Empurrar;
    private readonly InputAction m_Player_Agachar;
    private readonly InputAction m_Player_puxar;
    private readonly InputAction m_Player_SuperPulo;
    private readonly InputAction m_Player_braço;
    private readonly InputAction m_Player_Puxar;
    private readonly InputAction m_Player_EsticarBraço;
    private readonly InputAction m_Player_passarfase;
    private readonly InputAction m_Player_retrocederfase;
    public struct PlayerActions
    {
        private @Inputs m_Wrapper;
        public PlayerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pular => m_Wrapper.m_Player_Pular;
        public InputAction @Andar => m_Wrapper.m_Player_Andar;
        public InputAction @Empurrar => m_Wrapper.m_Player_Empurrar;
        public InputAction @Agachar => m_Wrapper.m_Player_Agachar;
        public InputAction @puxar => m_Wrapper.m_Player_puxar;
        public InputAction @SuperPulo => m_Wrapper.m_Player_SuperPulo;
        public InputAction @braço => m_Wrapper.m_Player_braço;
        public InputAction @Puxar => m_Wrapper.m_Player_Puxar;
        public InputAction @EsticarBraço => m_Wrapper.m_Player_EsticarBraço;
        public InputAction @passarfase => m_Wrapper.m_Player_passarfase;
        public InputAction @retrocederfase => m_Wrapper.m_Player_retrocederfase;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Pular.started += instance.OnPular;
            @Pular.performed += instance.OnPular;
            @Pular.canceled += instance.OnPular;
            @Andar.started += instance.OnAndar;
            @Andar.performed += instance.OnAndar;
            @Andar.canceled += instance.OnAndar;
            @Empurrar.started += instance.OnEmpurrar;
            @Empurrar.performed += instance.OnEmpurrar;
            @Empurrar.canceled += instance.OnEmpurrar;
            @Agachar.started += instance.OnAgachar;
            @Agachar.performed += instance.OnAgachar;
            @Agachar.canceled += instance.OnAgachar;
            @puxar.started += instance.OnPuxar;
            @puxar.performed += instance.OnPuxar;
            @puxar.canceled += instance.OnPuxar;
            @SuperPulo.started += instance.OnSuperPulo;
            @SuperPulo.performed += instance.OnSuperPulo;
            @SuperPulo.canceled += instance.OnSuperPulo;
            @braço.started += instance.OnBraço;
            @braço.performed += instance.OnBraço;
            @braço.canceled += instance.OnBraço;
            @Puxar.started += instance.OnPuxar;
            @Puxar.performed += instance.OnPuxar;
            @Puxar.canceled += instance.OnPuxar;
            @EsticarBraço.started += instance.OnEsticarBraço;
            @EsticarBraço.performed += instance.OnEsticarBraço;
            @EsticarBraço.canceled += instance.OnEsticarBraço;
            @passarfase.started += instance.OnPassarfase;
            @passarfase.performed += instance.OnPassarfase;
            @passarfase.canceled += instance.OnPassarfase;
            @retrocederfase.started += instance.OnRetrocederfase;
            @retrocederfase.performed += instance.OnRetrocederfase;
            @retrocederfase.canceled += instance.OnRetrocederfase;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Pular.started -= instance.OnPular;
            @Pular.performed -= instance.OnPular;
            @Pular.canceled -= instance.OnPular;
            @Andar.started -= instance.OnAndar;
            @Andar.performed -= instance.OnAndar;
            @Andar.canceled -= instance.OnAndar;
            @Empurrar.started -= instance.OnEmpurrar;
            @Empurrar.performed -= instance.OnEmpurrar;
            @Empurrar.canceled -= instance.OnEmpurrar;
            @Agachar.started -= instance.OnAgachar;
            @Agachar.performed -= instance.OnAgachar;
            @Agachar.canceled -= instance.OnAgachar;
            @puxar.started -= instance.OnPuxar;
            @puxar.performed -= instance.OnPuxar;
            @puxar.canceled -= instance.OnPuxar;
            @SuperPulo.started -= instance.OnSuperPulo;
            @SuperPulo.performed -= instance.OnSuperPulo;
            @SuperPulo.canceled -= instance.OnSuperPulo;
            @braço.started -= instance.OnBraço;
            @braço.performed -= instance.OnBraço;
            @braço.canceled -= instance.OnBraço;
            @Puxar.started -= instance.OnPuxar;
            @Puxar.performed -= instance.OnPuxar;
            @Puxar.canceled -= instance.OnPuxar;
            @EsticarBraço.started -= instance.OnEsticarBraço;
            @EsticarBraço.performed -= instance.OnEsticarBraço;
            @EsticarBraço.canceled -= instance.OnEsticarBraço;
            @passarfase.started -= instance.OnPassarfase;
            @passarfase.performed -= instance.OnPassarfase;
            @passarfase.canceled -= instance.OnPassarfase;
            @retrocederfase.started -= instance.OnRetrocederfase;
            @retrocederfase.performed -= instance.OnRetrocederfase;
            @retrocederfase.canceled -= instance.OnRetrocederfase;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPular(InputAction.CallbackContext context);
        void OnAndar(InputAction.CallbackContext context);
        void OnEmpurrar(InputAction.CallbackContext context);
        void OnAgachar(InputAction.CallbackContext context);
        void OnPuxar(InputAction.CallbackContext context);
        void OnSuperPulo(InputAction.CallbackContext context);
        void OnBraço(InputAction.CallbackContext context);
        
        void OnEsticarBraço(InputAction.CallbackContext context);
        void OnPassarfase(InputAction.CallbackContext context);
        void OnRetrocederfase(InputAction.CallbackContext context);
    }
}