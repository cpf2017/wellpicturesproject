using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ZoomDemo : MonoBehaviour,IManipulationHandler {


    Vector3 localScale;
    public GameObject objBig;
    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
       
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
         localScale = objBig.transform.localScale;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        

        Vector3 scale = new Vector3(1.1f * localScale.x, 1.1f * localScale.y, 1.1f * localScale.z);

        objBig.transform.localScale = scale;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
