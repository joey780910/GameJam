using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuWnd : MonoBehaviour {
    public Button start;
    public Button scoreBoard;
	// Use this for initialization
	void Start () {
        selfActive(true);
        start.onClick.AddListener(() =>
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
