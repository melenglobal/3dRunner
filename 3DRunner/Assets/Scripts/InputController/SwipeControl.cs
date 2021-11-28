// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputController/SwipeControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SwipeControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SwipeControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SwipeControl"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""f04253d8-89ea-42d4-b95e-a190d6f84f04"",
            ""actions"": [
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""Value"",
                    ""id"": ""cdb35786-d616-4932-afd5-960c6988dec6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6e12fd9b-c6e1-441a-8e8a-225b8ae5032c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a8fdd98-2c69-4e5c-b1a8-385e3e1a934e"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_MoveZ = m_Move.FindAction("MoveZ", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_MoveZ;
    public struct MoveActions
    {
        private @SwipeControl m_Wrapper;
        public MoveActions(@SwipeControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveZ => m_Wrapper.m_Move_MoveZ;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @MoveZ.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveZ;
                @MoveZ.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveZ;
                @MoveZ.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveZ;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveZ.started += instance.OnMoveZ;
                @MoveZ.performed += instance.OnMoveZ;
                @MoveZ.canceled += instance.OnMoveZ;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnMoveZ(InputAction.CallbackContext context);
    }
}
