using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteManager : MonoBehaviour {

    public GameObject chaji;
    public GameObject chuang;
    public GameObject yizi;
    public GameObject shafa;
    public GameObject zhuozi;
    public GameObject shugui;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Chajidelete()
    {
        Destroy(chaji);
    }
    public void Chuangdelete()
    {
        Destroy(chuang);
    }
    public void Yizidelete()
    {
        Destroy(yizi);
    }
    public void Shafadelete()
    {
        Destroy(shafa);
    }
    public void Zhuozidelete()
    {
        Destroy(zhuozi);
    }
    public void Shuguidelete()
    {
        Destroy(shugui);
    }
}
