using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ShowBlock : MonoBehaviour,IInputClickHandler
{
    public GameObject block7;
    private GameObject lou_01;
    private GameObject intro1;
    private Lou_01_room lou01Script;
    private GameObject lou_02;
    private GameObject intro2;
    private GameObject plan;
    private GameObject wall;
    private GameObject Room_01;
    private GameObject Room_02;
    private Transform back1;
    private Transform back2;
    private Transform back3;
    // Use this for initialization
    void Start () {
        lou_01 = GameObject.Find("lou_01");
        intro1 = GameObject.Find("intro1");
        lou01Script = block7.GetComponent<Lou_01_room>();
        lou_02 = GameObject.Find("lou_02");
        intro2 = GameObject.Find("intro2");
        plan = GameObject.Find("plan");
        wall = GameObject.Find("wall");
        Room_01 = GameObject.Find("Room_01");
        Room_02 = GameObject.Find("Room_02");
        back1 = transform.Find("BUT/back1");
        back2 = transform.Find("BUT/back2");
        //back3 = transform.Find("BUT/back3");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
 
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Lou01();
        Lou02();
    }

    void Lou01()
    {
        if (GazeManager.Instance.HitObject == lou_01)
        {
            intro1.SetActive(false);
            lou_02.SetActive(false);
            plan.SetActive(false);
            wall.SetActive(false);
            back2.gameObject.SetActive(true);
            back1.gameObject.SetActive(false);
            enabled = false;
            lou01Script.enabled = true;
            //Room_01.SetActive(false);
            //Room_02.SetActive(false);
        }
        else
        {
            return;
        }
    }
    void Lou02()
    {
        if(GazeManager.Instance.HitObject == lou_02)
        {
            intro2.SetActive(false);
            lou_01.SetActive(false);
            plan.SetActive(false);
            wall.SetActive(false);
            back2.gameObject.SetActive(true);
            back1.gameObject.SetActive(false);
            enabled = false;
            lou01Script.enabled = true;
        }
        else
        {
            return;
        }
    }
    public void GoBack2()
    {
        intro1.SetActive(true);
        intro2.SetActive(true);
        lou_01.SetActive(true);
        lou_02.SetActive(true);
        plan.SetActive(true);
        wall.SetActive(true);
        back2.gameObject.SetActive(false);
        back1.gameObject.SetActive(true);
        enabled = true;
        lou01Script.enabled = false;
    }
}
