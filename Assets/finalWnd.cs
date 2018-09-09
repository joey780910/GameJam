using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalWnd : MonoBehaviour {
    public Button restart;
    public Button scoreBoard;
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
            selfActive(false);
        });
    }
	public void selfActive(bool act)
    {
        gameObject.SetActive(act);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
