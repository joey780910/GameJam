using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour {
    public Button botton;
    public Action click;
    private Image img;
    // Use this for initialization
    void Start () {
        img = GetComponent<Image>();
        botton.onClick.AddListener(() =>
        {
            if (click != null)
            {
                click();
            }
        }
        );
        

	}
	public void setData(Color color, Action _act)
    {
        img.color = color;
        click = _act;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
