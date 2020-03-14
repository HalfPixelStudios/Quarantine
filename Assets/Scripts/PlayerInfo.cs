using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    [HideInInspector] public Rigidbody2D rb;

    [Range(0f,1f)] public float inputThreshold;

    [HideInInspector] public PlayerInputActions inputAction;
    [HideInInspector] public Vector2 moveInput;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        inputAction = new PlayerInputActions();

        inputAction.PlayerControls.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
    }

    void Update() {
        
    }
}
