using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top10Obj : MonoBehaviour {

    public Text scoreText;

    public void SetData(int index, int score)
    {
        if(score == -1)
        {
            scoreText.text = "----------";
            return;
        }
        scoreText.text = index + ". Score : " + score;
    }
}
