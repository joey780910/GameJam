using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeWnd : MonoBehaviour {
    public Text TimeText;
    private float CountDownTime = 60f;
    private bool startGame = false;

	void Start () {
        startGame = true;
    }
	
	void Update ()
    {
        if (!startGame)
            return;

        if(CountDownTime <= 0)
        {
            CountDownTime = 60f;
            startGame = false;
            return;
        }
        CountDownTime -= Time.deltaTime;
        TimeText.text = ((int)CountDownTime).ToString();
    }
}
