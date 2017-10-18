using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class EdificeManager : MonoBehaviour, IInputClickHandler
{
    private GameObject wu;
    private HandDraggable move;
    private HoloRotate rotate;
    private HoloZoom zoom;
    private HomePosition home;
    InputClickedEventData click;
    // Use this for initialization
    void Start()
    {
        home = GetComponent<HomePosition>();
       
       // home.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        print(5555);
        wu = GameObject.FindGameObjectWithTag("edifice");
    
        if (GazeManager.Instance.HitObject == wu)
        {
            if (wu.GetComponent<HandDraggable>() == null && wu.GetComponent<HoloZoom>() == null && wu.GetComponent<HoloRotate>() == null)
            {
                //就添加这三个脚本，让他们都不激活，并且添加到数组
                wu.AddComponent<HandDraggable>();//移动

                wu.AddComponent<HoloZoom>();//缩放

                wu.AddComponent<HoloRotate>();//旋转  
            }

            move = wu.GetComponent<HandDraggable>();
            move.enabled = false;
            zoom = wu.GetComponent<HoloZoom>();
            zoom.enabled = false;
            rotate = wu.GetComponent<HoloRotate>();
            rotate.enabled = false;
        }
    }

    public void RotateWay1()
    {
        rotate.enabled = true;
        move.enabled = false;
        zoom.enabled = false;
    }
    public void MoveWay1()
    {
        move.enabled = true;
        rotate.enabled = false;
        zoom.enabled = false;
    }
    public void ZoomWay1()
    {
        zoom.enabled = true;
        rotate.enabled = false;
        move.enabled = false;
    }
    public void GoBack1()
    {
        home.Back();
        rotate.enabled = false;
        move.enabled = false;
        zoom.enabled = false;
    }
}
