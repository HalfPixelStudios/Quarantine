using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;
    private PlayerInfo info;

    
    // Start is called before the first frame update
    void Start()
    {
        info = GetComponent<PlayerInfo>();


    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0||gameObject.transform.position.y<-5)
        {
            transform.position = new Vector2(0, 0);
            if (info.isControlled)
            {
                
                GameObject g = Instantiate(GlobalContainer.global.player, transform.parent);
                g.GetComponent<Replay>().jumpInputs = GetComponent<PlayerInfo>().pastJumps;
                g.GetComponent<Replay>().moveInputs = GetComponent<PlayerInfo>().pastMoves;
                GlobalContainer.global.players.Add(g);
                GlobalContainer.global.GetComponent<DeathMenu>().activate();

            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        
    }
    
}
