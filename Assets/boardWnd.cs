using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boardWnd : MonoBehaviour {
    public Button back;
	// Use this for initialization
	void Start () {
        back.onClick.AddListener(() =>
        {
            selfActive(false);
        }
        );
    }
    public void selfActive(bool act)
    {
        gameObject.SetActive(act);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
