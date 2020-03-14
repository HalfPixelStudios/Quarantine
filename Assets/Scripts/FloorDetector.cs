using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalContainer;

[RequireComponent(typeof(BoxCollider2D))]
public class FloorDetector : MonoBehaviour {

    public bool isOnGround;

    void FixedUpdate() {
        isOnGround = false;
    }

    private void OnTriggerStay2D(Collider2D collision) {

        if (global.ground_layers.Contains(collision.gameObject.layer)) {
            isOnGround = true;
        }
    }

}
