using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTools;

public class GameManager : AGameManager<GameManager, GameManager.GameStates>
{
    public int fortressPoints = 10;
    public int totalScore = 0;
    public enum GameStates
    {
        Play,
        Pause,
        End
    }

    GameStates gameStates;

    public void addPointsToScore(int newScore)
    {
        totalScore += newScore;
    }

    public void loosingFortressPoints(int points)
    {
        fortressPoints += points;
        if (fortressPoints <= 0)
        {
            gameStates = GameStates.End;
        }
    }
}
