using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuWnd : MonoBehaviour {
    public Button start;
	// Use this for initialization
	void Start () {
        start.onClick.AddListener(() => 
        {
            gameObject.SetActive(false);
        }
        );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
