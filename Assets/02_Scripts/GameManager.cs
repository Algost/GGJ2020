using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTools;
using TMPro;

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

    public void Awake()
    {
        GameObject.Find("GUI/Canvas/scoreTxt").GetComponent<TextMeshProUGUI>().SetText(totalScore.ToString());
        GameObject.Find("GUI/Canvas/lifePointsTxt").GetComponent<TextMeshProUGUI>().SetText(fortressPoints.ToString());
    }
    GameStates gameStates;
    void OnPlayGame()
    {
        print("toto");
    }

    void OnFixedPlayGame()
    {
        print("fixed");
    }

    public void addPointsToScore(int newScore)
    {
        totalScore += newScore;
        GameObject.Find("GUI/Canvas/scoreTxt").GetComponent<TextMeshProUGUI>().SetText(totalScore.ToString());
    }

    public void loosingFortressPoints(int points)
    {
        fortressPoints += points;
        if (fortressPoints <= 0)
        {
            GameObject.Find("GUI/Canvas/lifePointsTxt").GetComponent<TextMeshProUGUI>().SetText(fortressPoints.ToString());
            gameStates = GameStates.End;
        }
    }
}
