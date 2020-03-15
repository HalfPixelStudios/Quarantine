using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    public List<Vector2> moveInputs;
    public List<float> jumpInputs;
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
        
        pInfo.jumpInput = jumpInputs[index];
        pInfo.moveInput = moveInputs[index];
        index += 1;


    }
}
