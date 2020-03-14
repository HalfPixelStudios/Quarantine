using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    [HideInInspector] public Rigidbody2D rb;

    [Range(0f,1f)] public float inputThreshold;

    [HideInInspector] public PlayerInputActions inputAction;
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        inputAction = new PlayerInputActions();

        inputAction.PlayerControls.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
    }

    void Update() {
        
    }

    private void OnEnable() {
        inputAction.Enable();
    }

    private void OnDisable() {
        inputAction.Disable();
    }
}
