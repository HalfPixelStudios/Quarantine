using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{


    [HideInInspector] public PlayerInputActions inputAction;
    private void Awake()
    {
        PlayerInfo pInfo = GetComponent<PlayerInfo>();
        
        
        inputAction = new PlayerInputActions();

        inputAction.PlayerControls.Move.performed += ctx => pInfo.moveInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.Jump.performed += ctx => pInfo.jumpInput = ctx.ReadValue<float>();
    }
    private void OnEnable() {
        inputAction.Enable();
    }

    private void OnDisable() {
        inputAction.Disable();
    }
}
