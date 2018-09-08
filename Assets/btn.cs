using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour {
    public Button botton;
    public Action click;
    public Image icon;
    private Image img;
    // Use this for initialization
    void Awake () {
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
	public void setData(Sprite spr, Color color, Action _act)
    {
        icon.sprite = spr;
        img.color = color;
        click = _act;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
