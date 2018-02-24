using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

//单双击控制移动和旋转的切换

public class ControlMoveAndRotate : MonoBehaviour,IInputClickHandler
{

    private HandDraggable move;
    private HoloRotate zoom;
    private float timelost = 0;

    // Use this for initialization
    void Start () {

        move = GetComponent<HandDraggable>();
        zoom = GetComponent<HoloRotate>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //双击，缩放
            if (Time.time - timelost < 1)
            {

                move.IsDraggingEnabled = false;
                zoom.enabled = true;
            }
            //单击，移动
            else if (Time.time - timelost > 1)
            {
                move.IsDraggingEnabled = true;
                zoom.enabled = false;
            }
              timelost = Time.time;
    }
}
