using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Chuang_tap : MonoBehaviour,IInputClickHandler
{
    private GameObject chuang_01;
    private GameObject chuang_02;
    private GameObject chuang_03;
    private GameObject chuang_04;
    private GameObject chuang_05;
    private GameObject chuang_06;
    private GameObject chuang;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {

        chuang_01 = GameObject.Find("chuang_01");
        chuang_02 = GameObject.Find("chuang_02");
        chuang_03 = GameObject.Find("chuang_03");
        chuang_04 = GameObject.Find("chuang_04");
        chuang_05 = GameObject.Find("chuang_05");
        chuang_06 = GameObject.Find("chuang_06");
        chuang = Resources.Load("chuang") as GameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Chuang01_Show();
        Chuang02_Show();
        Chuang03_Show();
        Chuang04_Show();
        Chuang05_Show();
        Chuang06_Show();

    }


    void Chuang01_Show()
    {
        if(GazeManager.Instance.HitObject == chuang_01)
        {
            //GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang,chuang_01.transform.position,chuang.transform.rotation);
        }
    }
    void Chuang02_Show()
    {
        if (GazeManager.Instance.HitObject == chuang_02)
        {
            //GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang, chuang_02.transform.position, chuang.transform.rotation);
        }
    }
    void Chuang03_Show()
    {
        if (GazeManager.Instance.HitObject == chuang_03)
        {
           // GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang, chuang_03.transform.position, chuang.transform.rotation);
        }
    }
    void Chuang04_Show()
    {
        if (GazeManager.Instance.HitObject == chuang_04)
        {
           // GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang, chuang_04.transform.position, chuang.transform.rotation);
        }
    }
    void Chuang05_Show()
    {
        if (GazeManager.Instance.HitObject == chuang_05)
        {
            //GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang, chuang_05.transform.position, chuang.transform.rotation);
        }
    }
    void Chuang06_Show()
    {
        if (GazeManager.Instance.HitObject == chuang_06)
        {
            //GameObject chuang = Resources.Load("chuang") as GameObject;
            Instantiate(chuang, chuang_06.transform.position, chuang.transform.rotation);
        }
    }

    public void Deletechuang()
    {
        Destroy(Deleteob);
    }
}
