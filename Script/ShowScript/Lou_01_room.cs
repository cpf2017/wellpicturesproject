using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Lou_01_room : MonoBehaviour,IInputClickHandler
{
    private Transform lou_01;
    private Transform lou_02;
    private Transform Room_01;
    private Transform Room_02;
    private Transform back2;
    private Transform back3;
    private Transform back4;
    // Use this for initialization
    void Start () {
        lou_01 = transform.Find("lou_01_bg/lou_01");
        Room_01 = transform.Find("lou_01_bg/Room_01");
        lou_02 = transform.Find("lou_02_bg/lou_02");
        Room_02 = transform.Find("lou_02_bg/Room_02");
        back2 = transform.Find("BUT/back2");
        back3 = transform.Find("BUT/back3");
        back4 = transform.Find("BUT/back4");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Tapped()
    {
        
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Intro1Manager();
        Intro2Manager();
    }

    void Intro1Manager()
    {
        if (GazeManager.Instance.HitObject == lou_01.gameObject)
        {
            lou_01.gameObject.SetActive(false);
            Room_01.gameObject.SetActive(true);
            back2.gameObject.SetActive(false);
            back3.gameObject.SetActive(true);
        }
        else
        {
            return;
        }
    }
    void Intro2Manager()
    {
        if(GazeManager.Instance.HitObject == lou_02.gameObject)
        {
            lou_02.gameObject.SetActive(false);
            Room_02.gameObject.SetActive(true);
            back2.gameObject.SetActive(true);
            back4.gameObject.SetActive(true);
        }
        else
        {
            return;
        }
    }
    public void GoBack3()
    {
        lou_01.gameObject.SetActive(true);
        Room_01.gameObject.SetActive(false);
        back3.gameObject.SetActive(false);
        back2.gameObject.SetActive(true);
        
    }
    public void GoBack4()
    {
        lou_02.gameObject.SetActive(true);
        Room_02.gameObject.SetActive(false);
        back4.gameObject.SetActive(false);
        back2.gameObject.SetActive(true);
    }
}
