using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeWnd : MonoBehaviour {
    public Text TimeText;
    public Text CountDownText;
    public GameObject CountDownObj;
    public GameObject MaskObj;

    private int CountDownSec = 5;
    private float CountDownTime = 60f;
    private bool startGame = false;

	void Start () {
        
    }
	
	void Update ()
    {
        if (!startGame)
            return;

        if(CountDownTime <= 0)
        {
            CountDownTime = 60f;
            startGame = false;
            Manager.instance.GameTimeUp();
            return;
        }
        CountDownTime -= Time.deltaTime;
        TimeText.text = "Time : " + ((int)CountDownTime).ToString();
    }

    public void StartGameCountDown()
    {
        MaskObj.SetActive(true);

        TimeText.text = "Time : " + ((int)CountDownTime).ToString();

        CountDownObj.SetActive(true);
        CountDownSec = 3;
        CountDownText.text = CountDownSec.ToString();
        Invoke("UpdateCountSecText", 1);
    }

    void UpdateCountSecText()
    {
        if(CountDownSec <= 0)
        {
            startGame = true;
            CountDownObj.SetActive(false);
            Manager.instance.StartGame();
            MaskObj.SetActive(false);

            return;
        }
        CountDownSec--;
        CountDownText.text = CountDownSec.ToString();
        Invoke("UpdateCountSecText", 1);
    }
}
