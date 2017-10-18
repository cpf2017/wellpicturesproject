using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCubeActive : MonoBehaviour {

    public MeshRenderer m; //获取物体着色器
    public Collider c;    //获取物体碰撞器
    public GameObject zi;
    // Use this for initialization
    void Start () {
        m = this.gameObject.GetComponent<MeshRenderer>();
        c = this.gameObject.GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    //隐藏球
    public void Hide()
    {
        
        m.enabled = false;
        c.enabled = false;
        zi = this.transform.Find("Cube").gameObject;
        zi.GetComponent<MeshRenderer>().enabled =true;
        zi.GetComponent<Collider>().enabled = true;    
    }
    //隐藏小方块
    public void Show()
    {
        
        m.enabled = true;
        c.enabled = true;
        zi = this.transform.Find("Cube").gameObject;
        zi.GetComponent<MeshRenderer>().enabled = false;
        zi.GetComponent<Collider>().enabled = false;
    }
}
