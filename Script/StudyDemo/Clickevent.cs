using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Clickevent : MonoBehaviour,IInputClickHandler {

    GameObject obj;
    TapToPlace move;
    Renderer ren;
    // Use this for initialization
    void Start () {
        obj = GameObject.Find("Cube");
        //move = obj.GetComponent<TapToPlace>();
        //print(move);
        ren = obj.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if(eventData.TapCount == 1)
        {
            //move.enabled = true;
           print("11111");
            ren.material.color = Color.red;
        }
        else if(eventData.TapCount ==2)
        {
           // move.enabled = false;
            print("22222");
            ren.material.color = Color.green;
        }
        else
        {
            print("3333");
            ren.material.color = Color.blue;
        }
        
    }

}
