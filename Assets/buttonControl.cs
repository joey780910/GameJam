using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonControl : MonoBehaviour {
    public List<btn> buttonList = new List<btn>();
    public int score=0;
    private System.Random r = new System.Random();
    public void updateBotton()
    {
        int index = r.Next(0, 4);
        for(int i = 0; i < buttonList.Count; i++)
        {
            if (i == index)
            {
                buttonList[i].setData(Color.red, () =>
                {
                    score += 1;
                    updateBotton();
                });
            }
            else
            {
                buttonList[i].setData(Color.green, () =>
                {
                    score -= 2;
                    updateBotton();
                });
            }
        }
    }

    // Use this for initialization

    void Start () {
        updateBotton();
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
