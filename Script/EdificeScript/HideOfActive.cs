using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOfActive : MonoBehaviour {
 
    private MeshRenderer mesh;
    private Collider coll;
    private GameObject obj;
    private GameObject ga;
	// Use this for initialization
	void Start () {
        //ga = GameObject.Find("Model");
        mesh = gameObject.GetComponent<MeshRenderer>();
        coll = gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //隐藏高亮的建筑，显示户型
    public void Hide()
    {
        coll.enabled = false;
        obj = transform.Find("Room_H").gameObject;
        obj.GetComponent<MeshRenderer>().enabled = true;
        obj.GetComponent<Collider>().enabled = true;
    }
    //隐藏户型，显示高亮的建筑
    public void Show()
    {
        coll.enabled = true;
        obj = transform.Find("Room_H").gameObject;
        obj.GetComponent<MeshRenderer>().enabled = false;
        obj.GetComponent<Collider>().enabled = false;
    }
}
