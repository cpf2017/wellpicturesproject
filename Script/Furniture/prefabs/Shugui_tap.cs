using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Shugui_tap : MonoBehaviour, IInputClickHandler
{

    private GameObject shugui_01;
    private GameObject shugui_02;
    private GameObject shugui_03;
    private GameObject shugui_04;
    private GameObject shugui_05;
    private GameObject shugui_06;
    private GameObject shu;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {
        shugui_01 = GameObject.Find("shugui_01");
        shugui_02 = GameObject.Find("shugui_02");
        shugui_03 = GameObject.Find("shugui_03");
        shugui_04 = GameObject.Find("shugui_04");
        shugui_05 = GameObject.Find("shugui_05");
        shugui_06 = GameObject.Find("shugui_06");
        shu = Resources.Load("shugui") as GameObject;
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Shugui01_Show();
        Shugui02_Show();
        Shugui03_Show();
        Shugui04_Show();
        Shugui05_Show();
        Shugui06_Show();

    }

    void Shugui01_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_01)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_01.transform.position, shu.transform.rotation);
        }
    }
    void Shugui02_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_02)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_02.transform.position, shu.transform.rotation);
        }
    }
    void Shugui03_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_03)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_03.transform.position, shu.transform.rotation);
        }
    }
    void Shugui04_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_04)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_04.transform.position, shu.transform.rotation); 
        }
    }
    void Shugui05_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_05)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_05.transform.position, shu.transform.rotation);
        }
    }
    void Shugui06_Show()
    {
        if (GazeManager.Instance.HitObject == shugui_06)
        {
            //GameObject shu = Resources.Load("shugui") as GameObject;
            Instantiate(shu, shugui_06.transform.position, shu.transform.rotation);
        }
    }
    public  void Deleteshugui()
    {
        Destroy(Deleteob);
    }
}
