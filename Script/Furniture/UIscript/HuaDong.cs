using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;
using UnityEngine.UI;

public class HuaDong : MonoBehaviour, IInputClickHandler
{
   
    float t = 0;
    private float speed = 4;
    float v = 0.3f;
    float c;
    //private ScrollRect scrollRect;
    
    private Transform all_bg;
    private Transform bg_01;
    private Transform bg_02;
    private Transform bg_03;
    private Transform bg_04;
    private Transform bg_05;
    private Transform bg_06;

    private GameObject up;
    private GameObject down;
    private Transform up_01;
    private Transform up_02;
    private Transform up_03;
    private Transform up_04;
    private Transform up_05;
    private Transform up_06;
    private GameObject down_01;
    private GameObject down_02;
    private GameObject down_03;
    private GameObject down_04;
    private GameObject down_05;
    private GameObject down_06;

    void Start()
    {
        //scrollRect = GameObject.Find("bian").GetComponent<ScrollRect>();
        up = GameObject.Find("up");
        down = GameObject.Find("down");

        all_bg = transform.Find("all/bian/all_bg");
        bg_01 = transform.Find("chuang/bian/bg_01");
        bg_02 = transform.Find("yizi/bian/bg_02");
        bg_03 = transform.Find("shafa/bian/bg_03");
        bg_04 = transform.Find("zhuozi/bian/bg_04");
        bg_05 = transform.Find("chaji/bian/bg_05");
        bg_06 = transform.Find("shugui/bian/bg_06");

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        A();
        B();
    }
    void A()
    {
        //float temp = scrollRect.verticalNormalizedPosition;
        if (GazeManager.Instance.HitObject == up)
        {
            all_bg.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_01.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_02.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_03.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_04.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_05.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;
            bg_06.transform.position += new Vector3(0, v, 0) * speed * Time.deltaTime;

        }
    }
    void B()
    {
       // float temp = scrollRect.verticalNormalizedPosition;
        if (GazeManager.Instance.HitObject == down)
        {
            all_bg.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_01.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_02.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_03.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_04.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_05.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
            bg_06.transform.position += new Vector3(0, -v, 0) * speed * Time.deltaTime;
        }
    }


}
