using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTools;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : AGameManager<GameManager, GameManager.GameStates>
{
    public int fortressPoints = 50;
    public int totalScore = 0;
    public List<GameObject> spawners;
    public enum GameStates
    {
        Play,
        Pause,
        End
    }

    public void Start()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        GameObject.Find("GUI/Canvas/scoreTxt").GetComponent<TextMeshProUGUI>().SetText(totalScore.ToString());
       GameObject.Find("GUI/Canvas/lifePointsTxt").GetComponent<TextMeshProUGUI>().SetText(fortressPoints.ToString());
    }
    GameStates gameStates;

    public void gamePaused()
    {
        gameStates = GameStates.Pause;
        Time.timeScale = 0.0f;
    }

    public void gameEnd()
    {
        gameStates = GameStates.End;
        Time.timeScale = 0.0f;
        GameObject.Find("GUI/Canvas/GameOver").SetActive(true);
        GameObject.Find("GUI/Canvas/restartBtn").SetActive(true);
    }

    public void restartScene()
    {
        totalScore = 0;
        GameObject.Find("GUI/Canvas/scoreTxt").GetComponent<TextMeshProUGUI>().SetText(totalScore.ToString());
        SceneManager.LoadScene(2);
    }


    public void addPointsToScore(MobController mob)
    {
        totalScore += mob.mobPoints;
        GameObject.Find("GUI/Canvas/scoreTxt").GetComponent<TextMeshProUGUI>().SetText(totalScore.ToString());
        if (totalScore % 1000 == 0 && totalScore > 0)
        {
            addASpawner();
        }
    }

    public void addASpawner()
    {
        //Debug.LogError("addASpawner");
        if (spawners.Count == 0)
            return;
        GameObject tmp = spawners[Random.Range(0, spawners.Count)];
        tmp.SetActive(true);
        spawners.Remove(tmp);
    }

    public void loosingFortressPoints(int points)
    {
        fortressPoints += points;
        GameObject.Find("GUI/Canvas/lifePointsTxt").GetComponent<TextMeshProUGUI>().SetText(fortressPoints.ToString());
        if (fortressPoints <= 0)
        {
            gameEnd();
        }
    }
}
