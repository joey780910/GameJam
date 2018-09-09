using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonControl : MonoBehaviour {
    public List<btn> buttonList = new List<btn>();
    public Sprite Attick;
    public Sprite Meat;
    public int score=0;
    private System.Random r = new System.Random();
    public void updateBotton()
    {
        int index = r.Next(0, 4);
        for(int i = 0; i < buttonList.Count; i++)
        {
            if (i == index)
            {
                buttonList[i].setData(Attick, Color.red, () =>
                {
                    score += 1;
                    Manager.instance.ScoreUpdate(1);
                    updateBotton();
                });
            }
            else
            {
                buttonList[i].setData(Meat, Color.green, () =>
                {
                    score -= 2;
                    Manager.instance.ScoreUpdate(-2);
                    updateBotton();
                });
            }
        }
    }

    public void ResetGame()
    {
        updateBotton();
        score = 0;
    }
    public int getScore()
    {
        return score;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
