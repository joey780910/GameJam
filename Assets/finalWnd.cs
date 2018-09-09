using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalWnd : MonoBehaviour {
    public Button restart;
    public Button scoreBoard;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        selfActive(false);
        
        restart.onClick.AddListener(() =>
        {
            Manager.instance.StartGameCountDown();
            selfActive(false);
        });

        scoreBoard.onClick.AddListener(() =>
        {
            Manager.instance.ShowTop10();
            //selfActive(false);
        });
    }
	public void selfActive(bool act)
    {
        gameObject.SetActive(act);
    }
    public void setScore(int score)
    {
        scoreText.text = "遊戲結束\n分數：" + score;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
