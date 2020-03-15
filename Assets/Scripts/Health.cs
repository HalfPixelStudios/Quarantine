using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;

    private bool isControlled;
    // Start is called before the first frame update
    void Start()
    {
        isControlled = GetComponent<Replay>() == null;

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0||gameObject.transform.position.y<-5)
        {
            if (isControlled)
            {

                transform.position = new Vector2(0, 0);
                GameObject g = Instantiate(GlobalContainer.global.player, transform.parent);
                g.GetComponent<Replay>().jumpInputs = GetComponent<PlayerInfo>().pastJumps;
                g.GetComponent<Replay>().moveInputs = GetComponent<PlayerInfo>().pastMoves;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }
    
}
