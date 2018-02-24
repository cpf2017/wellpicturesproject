using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Zhuozi_tap : MonoBehaviour, IInputClickHandler
{

    private GameObject zhuozi_01;
    private GameObject zhuozi_02;
    private GameObject zhuozi_03;
    private GameObject zhuozi_04;
    private GameObject zhuozi_05;
    private GameObject zhuozi_06;
    private GameObject zhuo;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {

        zhuozi_01 = GameObject.Find("zhuozi_01");
        zhuozi_02 = GameObject.Find("zhuozi_02");
        zhuozi_03 = GameObject.Find("zhuozi_03");
        zhuozi_04 = GameObject.Find("zhuozi_04");
        zhuozi_05 = GameObject.Find("zhuozi_05");
        zhuozi_06 = GameObject.Find("zhuozi_06");
        zhuo = Resources.Load("zhuozi") as GameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Zhuozi01_Show();
        Zhuozi02_Show();
        Zhuozi03_Show();
        Zhuozi04_Show();
        Zhuozi05_Show();

    }

    void Zhuozi01_Show()
    {
        if(GazeManager.Instance.HitObject == zhuozi_01)
        {
           // GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_01.transform.position, zhuozi_01.transform.rotation);

        }
    }
    void Zhuozi02_Show()
    {
        if (GazeManager.Instance.HitObject == zhuozi_02)
        {
            //GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_02.transform.position, zhuo.transform.rotation);
        }
    }
    void Zhuozi03_Show()
    {
        if (GazeManager.Instance.HitObject == zhuozi_03)
        {
           // GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_03.transform.position, zhuo.transform.rotation);
        }
    }
    void Zhuozi04_Show()
    {
        if (GazeManager.Instance.HitObject == zhuozi_04)
        {
           // GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_04.transform.position, zhuo.transform.rotation);
        }
    }
    void Zhuozi05_Show()
    {
        if (GazeManager.Instance.HitObject == zhuozi_05)
        {
            //GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_05.transform.position, zhuo.transform.rotation);
        }
    }
    void Zhuozi06_Show()
    {
        if (GazeManager.Instance.HitObject == zhuozi_06)
        {
            //GameObject zhuo = Resources.Load("zhuozi") as GameObject;
            Instantiate(zhuo, zhuozi_06.transform.position, zhuo.transform.rotation);
        }
    }
    public void Deletezhuozi()
    {
        Destroy(Deleteob);
    }
}
