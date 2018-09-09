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
}
