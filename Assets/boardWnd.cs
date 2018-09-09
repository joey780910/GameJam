using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boardWnd : MonoBehaviour {
    public Button back;
    public Top10Obj top10ObjPrefab;
    public List<Top10Obj> ObjList = new List<Top10Obj>();
	// Use this for initialization
	void Start () {
        top10ObjPrefab.gameObject.SetActive(false);
        selfActive(false);

        back.onClick.AddListener(() =>
        {
            selfActive(false);
        });
    }
    public void selfActive(bool act)
    {
        gameObject.SetActive(act);
    }

    public void SetData()
    {
        for(int i = 0; i < ObjList.Count; i++)
        {
            ObjList[i].SetData(i + 1, Manager.instance.GetTop10Score((i+1).ToString()));
        }
    }

    public void CreateTop10()
    {
        if (ObjList.Count == 10)
            return;

        for(int i = 0; i < 10; i++)
        {
            
        }
    }
}
