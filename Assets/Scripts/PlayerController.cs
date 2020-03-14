using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    PlayerInfo info;

    [Range(0f, 10f)] public float move_speed;
    [Range(0f,10f)] public float max_speed;
    [Range(0f, 1f)] public float horizontal_drag;

    public GameObject jumpTrigger;


    void Start() {
        info = gameObject.GetComponent<PlayerInfo>();
    }

    void Update() {
        if (Mathf.Abs(info.moveInput.x) >= info.inputThreshold) {
            info.rb.velocity = new Vector2(info.moveInput.x * move_speed, info.rb.velocity.y);
        }

        Debug.Log(info.moveInput);
        /*

        if (Mathf.Abs(info.rb.velocity.x) >= 0.1f) { //apply horizontal damping
            info.rb.velocity = new Vector2(info.rb.velocity.y * horizontal_drag, info.rb.velocity.y);
        } else {
            info.rb.velocity = new Vector2(0, info.rb.velocity.y);
        }
        */
    }
}
