using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used to store global variables
public class GlobalContainer : MonoBehaviour {

    public static GlobalContainer global;

    public List<int> ground_layers; //objects that will cause player to reset jump
    public GameObject player;

    void Awake() {
        global = this;
    }

}
