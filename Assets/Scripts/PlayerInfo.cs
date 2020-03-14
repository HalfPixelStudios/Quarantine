using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    [HideInInspector] public Rigidbody2D rb;

    
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;


    //Children
    [HideInInspector] public GameObject sprite;

    [Range(0f,1f)] public float inputThreshold;
    List<Vector2> pastMoves;
    List<float> pastJumps;

    void Awake() {
        sprite = GetComponentInChildren<Animator>().gameObject;

        rb = GetComponent<Rigidbody2D>();

    }

    void Update() {
        
    }

    
}
