using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timer))]
public class PlayerController : MonoBehaviour {

    PlayerInfo info;

    [Range(0f, 10f)] public float move_speed;
    [Range(0f,10f)] public float max_speed;
    [Range(0f, 1f)] public float horizontal_drag;

    public GameObject jumpTrigger;
    [SerializeField] private float maxHoldTime, fallGFactor, lowJumpGFactor;
    Timer jumpTimer;


    void Start() {
        info = gameObject.GetComponentInParent<PlayerInfo>();
        jumpTimer = GetComponent<Timer>();
    }

    void Update() {

        //Movement
        if (Mathf.Abs(info.moveInput.x) >= info.inputThreshold) {
            
            info.rb.velocity = new Vector2(info.moveInput.x * move_speed, info.rb.velocity.y);
        }
        
        if (Mathf.Abs(info.rb.velocity.x) >= 0.1f) { //apply horizontal damping
            info.rb.velocity = new Vector2(info.rb.velocity.x * horizontal_drag, info.rb.velocity.y);
        } else {
            info.rb.velocity = new Vector2(0, info.rb.velocity.y);
        }


        //Jumping
        if (info.jumpInput >= info.inputThreshold) {

        }
    }
}
