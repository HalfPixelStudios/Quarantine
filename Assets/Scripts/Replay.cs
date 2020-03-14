using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    private List<Vector2> moveInputs;
    private List<float> jumpInputs;
    private int index = 0;
    private PlayerInfo pInfo;

    // Start is called before the first frame update
    void Start()
    {
        pInfo = GetComponent<PlayerInfo>();



    }

    // Update is called once per frame
    void Update()
    {
        index += 1;
        pInfo.jumpInput = jumpInputs[index];
        pInfo.moveInput = moveInputs[index];


    }
}
