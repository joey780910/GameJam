using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager instance;
    public List<Action> s = new List<Action>();
    public TopArea topArea;
    public TimeWnd timeWnd;
    public buttonControl btnControl;
    public finalWnd FWnd;
    public boardWnd BWnd;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        //s[rnd.Next(0, 4)] = 
    }

    public void StartGameCountDown()
    {
        timeWnd.StartGameCountDown();
        btnControl.ResetGame();
        topArea.ResetGame();
    }

    public void StartGame()
    {

    }

    public void GameTimeUp()
    {
        FWnd.selfActive(true);
        FWnd.setScore(btnControl.getScore());
        SaveTop10(btnControl.getScore());
    }

    public void ShowTop10()
    {
        BWnd.SetData();
    }

    public Dictionary<string, int> GetTop10()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for(int i = 1; i < 11; i++)
        {
            dict.Add(i.ToString(), GetTop10Score(i.ToString()));
        }
        return dict;
    }

    public void SaveTop10(int score)
    {
        var dict = GetTop10();

        for(int i = 1; i<11; i++)
        {
            if(score >= dict[i.ToString()])
            {
                //dict[i.ToString()] = score;
                SetTop10Score(i.ToString(), score);
                for(int j = i; j<10; j++)
                {
                    SetTop10Score((j+1).ToString(), dict[j.ToString()]);
                }
                return;
            }
        }
    }

    private void SetBtn(Action action, int value, Color color)
    {

    }
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScoreUpdate(int _score)
    {
        topArea.MonsterScale(_score);
    }

    public void SetTop10Score(string key, int score)
    {
        PlayerPrefs.SetInt(key, score);
    }

    public int GetTop10Score(string key)
    {
        return PlayerPrefs.GetInt(key, -1);
    }
}
