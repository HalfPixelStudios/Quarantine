using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FloorDetector : MonoBehaviour {

    public bool isOnGround;

    void FixedUpdate() {
        isOnGround = false;
    }

    private void OnTriggerStay(Collider other) {
        
    }
}
