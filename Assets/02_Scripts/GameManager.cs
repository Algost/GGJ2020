using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTools;

public class GameManager : AGameManager<GameManager, GameManager.GameStates>
{
    public enum GameStates
    {
        Play,
        Pause
    }
    
    void OnPlayGame()
    {
        print("toto");
    }

    void OnFixedPlayGame()
    {
        print("fixed");
    }
}
