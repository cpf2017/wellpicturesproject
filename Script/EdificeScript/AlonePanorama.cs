using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlonePanorama : MonoBehaviour {

    private GameObject fang;
    private Collider coll;

    private GameObject but1;
    private GameObject but2;
    private GameObject panorama;
    void Start () {

        fang = GameObject.Find("Edifice");
        coll = fang.GetComponent<Collider>();
        but1 = transform.Find("Button1").gameObject;
        but2 = transform.Find("Button2").gameObject;
        panorama = transform.Find("panorama").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Box()
    {
        panorama.SetActive(false);
        coll.enabled = false;
        but1.SetActive(false);
        but2.SetActive(true);
    }
    public void Box2()
    {
        coll.enabled = true;
        but1.SetActive(true);
        but2.SetActive(false);
    }

    public void But()
    {
        panorama.SetActive(true);
    }
}
