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
    [Range(0f, 10f)] public float jump_speed;
    [SerializeField] private float maxHoldTime, fallGFactor, lowJumpGFactor;
    Timer jumpTimer;

    //Animations
    private bool isMoving;
    private bool facing = true; //1 indicates facing right, 0 indicates facing left

    void Start() {
        info = gameObject.GetComponentInParent<PlayerInfo>();
        jumpTimer = GetComponent<Timer>();
        jumpTimer.duration = maxHoldTime;
    }

    void Update() {
        

        //Movement
        isMoving = false;
        if (Mathf.Abs(info.moveInput.x) >= info.inputThreshold) {
            info.rb.velocity = new Vector2(info.moveInput.x * move_speed, info.rb.velocity.y);
            isMoving = true;
        }

        if (Mathf.Abs(info.rb.velocity.x) >= 0.1f) { //apply horizontal damping
            info.rb.velocity = new Vector2(info.rb.velocity.x * horizontal_drag, info.rb.velocity.y);
        } else {
            info.rb.velocity = new Vector2(0, info.rb.velocity.y);
        }
        info.sprite.GetComponent<Animator>().SetBool("isMoving", isMoving);

        //Jumping =-=-=-=-=-=-
        //start jump
        if (info.jumpInput >= info.inputThreshold && jumpTrigger.GetComponent<FloorDetector>().isOnGround && !jumpTimer.isActive) {
            jumpTimer.activate();
        }
        //apply jump velocity
        if (info.jumpInput >= info.inputThreshold && jumpTimer.isActive) {
            info.rb.velocity = new Vector2(info.rb.velocity.x, jump_speed);
        }
        //when no longer holding jump, deactivate jump
        if (info.jumpInput < info.inputThreshold) {
            jumpTimer.deactivate();
        }

        //Apply gravity
        if (info.rb.velocity.y < 0) { //if player is falling, apply gravity scale
            info.rb.velocity += Vector2.up * Physics.gravity.y * (fallGFactor - 1) * Time.deltaTime;
        } else if (info.rb.velocity.y > 0 && info.jumpInput < info.inputThreshold) {
            info.rb.velocity += Vector2.up * Physics.gravity.y * (lowJumpGFactor - 1) * Time.deltaTime;
        }


        //Animation stuff =-=-=-=-=-=-

        //flip player sprite based on previous input
        if (Mathf.Abs(info.moveInput.x) >= info.inputThreshold) {
            facing = (info.moveInput.x >= 0 ? true : false);
            info.sprite.GetComponent<SpriteRenderer>().flipX = !facing;
        }
        

    }

        
}
