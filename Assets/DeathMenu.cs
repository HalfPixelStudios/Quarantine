using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
        GlobalContainer.global.deathMenu.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void restart()
    {
        print(true);
        foreach (var replay in GlobalContainer.global.players)
        {
            Destroy(replay);
            
        }
        GlobalContainer.global.players=new List<GameObject>();
        deactivate();
        
        
    }

    public void deactivate()
    {
        GlobalContainer.global.deathMenu.SetActive(false);
        Time.timeScale = 1;
        foreach (var replay in GlobalContainer.global.players)
        {
            replay.SetActive(true);
            
        }

    }

    public void scrap()
    {
        var players = GlobalContainer.global.players;
        Destroy(players[players.Count-1]);
        players.RemoveAt(players.Count-1);
        deactivate();
        
    }
}
