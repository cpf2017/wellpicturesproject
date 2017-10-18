using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;
//是下手时点击
public class GestureClick : MonoBehaviour,IInputClickHandler
{
  // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        FindObjectOfType<Cubescript>().Decline();
    }

  
}
