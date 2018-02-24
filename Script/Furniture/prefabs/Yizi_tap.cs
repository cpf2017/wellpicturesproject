using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Yizi_tap : MonoBehaviour, IInputClickHandler
{
    private GameObject yizi_01;
    private GameObject yizi_02;
    private GameObject yizi_03;
    private GameObject yizi_04;
    private GameObject yizi_05;
    private GameObject yizi_06;
    private GameObject yi;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {

        yizi_01 = GameObject.Find("yizi_01");
        yizi_02 = GameObject.Find("yizi_02");
        yizi_03 = GameObject.Find("yizi_03");
        yizi_04 = GameObject.Find("yizi_04");
        yizi_05 = GameObject.Find("yizi_05");
        yizi_06 = GameObject.Find("yizi_06");
        yi = Resources.Load("yizi") as GameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Yizi01_Show();
        Yizi02_Show();
        Yizi03_Show();
        Yizi04_Show();
        Yizi05_Show();
        Yizi06_Show();

    }

    void Yizi01_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_01)
        {
            //GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_01.transform.position, yi.transform.rotation);
        }
    }
    void Yizi02_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_02)
        {
            //GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_02.transform.position, yi.transform.rotation);
        }

    }
    void Yizi03_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_03)
        {
            //GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_03.transform.position, yi.transform.rotation);
        }
    }
    void Yizi04_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_04)
        {
           // GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_04.transform.position, yi.transform.rotation);
        }
    }
    void Yizi05_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_05)
        {
           // GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_05.transform.position, yi.transform.rotation);
        }
    }
    void Yizi06_Show()
    {
        if (GazeManager.Instance.HitObject == yizi_06)
        {
            //GameObject yi = Resources.Load("yizi") as GameObject;
            Instantiate(yi, yizi_06.transform.position, yi.transform.rotation);
        }
    }
    public void Deleteyizi()
    {
        Destroy(Deleteob);
    }
}
