using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Chaiji_tap : MonoBehaviour,IInputClickHandler {

    
    private GameObject chaji_01;
    private GameObject chaji_02;
    private GameObject chaji_03;
    private GameObject chaji_04;
    private GameObject chaji_05;
    private GameObject chaji_06;
    private GameObject cha;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {

        chaji_01 = GameObject.Find("chaji_01");
        chaji_02 = GameObject.Find("chaji_02");
        chaji_03 = GameObject.Find("chaji_03");
        chaji_04 = GameObject.Find("chaji_04");
        chaji_05 = GameObject.Find("chaji_05");
        chaji_06 = GameObject.Find("chaji_06");
        cha = Resources.Load("chaji") as GameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Chaji01_show();
        Chaji02_show();
        Chaji03_show();
        Chaji04_show();
        Chaji05_show();
        Chaji06_show();
    }


    void Chaji01_show()
    {
        if (GazeManager.Instance.HitObject == chaji_01)
        {
            //GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_01.transform.position, cha.transform.rotation);
        }
    }
    void Chaji02_show()
    {
        if(GazeManager.Instance.HitObject == chaji_02)
        {
            // GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_02.transform.position, cha.transform.rotation);
        }
    }
    void Chaji03_show()
    {
        if (GazeManager.Instance.HitObject == chaji_03)
        {
            // GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_03.transform.position, cha.transform.rotation);
        }
    }
    void Chaji04_show()
    {
        if (GazeManager.Instance.HitObject == chaji_04)
        {
            //GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_04.transform.position, cha.transform.rotation);
        }
    }
    void Chaji05_show()
    {
        if (GazeManager.Instance.HitObject == chaji_05)
        {
            //GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_05.transform.position, cha.transform.rotation);
        }
    }
    void Chaji06_show()
    {
        if (GazeManager.Instance.HitObject == chaji_06)
        {
            // GameObject cha = Resources.Load("chaji") as GameObject;
            Deleteob = Instantiate(cha, chaji_06.transform.position, cha.transform.rotation);
        }
    }

    public void Deletechaji()
    {
        Destroy(Deleteob);
    }
}
