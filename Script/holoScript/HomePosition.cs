using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePosition : MonoBehaviour {

    Vector3 pos;
    Quaternion rot;
    Vector3 scale;
    // Use this for initialization
    void Start () {
        //记住物体原来的位置，角度，缩放
        pos = this.transform.position;
        rot = this.transform.rotation;
        scale = this.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Back()
    {
        //将记录的信息付给当前
        this.gameObject.transform.position = pos;
        this.transform.rotation = rot;
        this.transform.localScale = scale;
    }
}
