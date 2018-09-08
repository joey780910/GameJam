using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopArea : MonoBehaviour {
    public Image monster;
    private float scaleChange = 0.1f;
    public float currentScale = 1;
    public float targetScale;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void MonsterScale(float value)
    {
        Debug.Log(value);

        float s = scaleChange * value;

        if (monster.transform.localScale.x - s <= 0)
        {
            monster.transform.localScale = Vector3.one;
            if (scaleChange - 0.01f <= 0.01f)
                return;
            scaleChange -= 0.01f;
            return;
        }
        else if(monster.transform.localScale.x - s > 1)
        {
            monster.transform.localScale = Vector3.one;
            return;
        }

        monster.transform.localScale = new Vector3(monster.transform.localScale.x - s,
                                                   monster.transform.localScale.y - s,
                                                   monster.transform.localScale.z - s);
    }
}
