using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ShowUI : MonoBehaviour {

    private Renderer intro1;
    private Renderer intro2;
    private GameObject obj1;
    private GameObject obj2;
    private Collider col;
    TapToPlace taptoplace;
    private Transform overall;
    //private Transform back1;
    //private Transform back2;
    // Use this for initialization
    void Start () {

        intro1 = GameObject.Find("intro1").GetComponent<MeshRenderer>();
        intro2 = GameObject.Find("intro2").GetComponent<MeshRenderer>();
        obj1 = GameObject.FindGameObjectWithTag("F1");
        obj2 = GameObject.FindGameObjectWithTag("F2");
        col = GetComponent<Collider>();
        taptoplace = GetComponent<TapToPlace>();
        overall = transform.Find("BUT/overall");
        //back1 = transform.Find("BUT/back1");
        //back2 = transform.Find("BUT/back2");
    }
	
	// Update is called once per frame
	void Update () {
        
        ShowIntro1();
        ShowIntro2();
    }

    void ShowIntro1()
    {
        if(GazeManager.Instance.HitObject == obj1)
        {
            intro1.enabled = true;
        }
        else
        {
            intro1.enabled = false;
        }
    }
    void ShowIntro2()
    {
        if (GazeManager.Instance.HitObject == obj2)
        {
            intro2.enabled = true;
        }
        else
        {
            intro2.enabled = false;
        }
    }
    public void ColloderManager()
    {
        col.enabled = false;
        taptoplace.enabled = false;
        overall.gameObject.SetActive(false);
    }

    public void GoBack1()
    {
        overall.gameObject.SetActive(true);
        col.enabled = true;
        taptoplace.enabled = true;
    }
}
