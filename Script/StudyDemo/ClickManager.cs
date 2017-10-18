using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ClickManager : MonoBehaviour {

    private GameObject Fang;
    public HandDraggable move;
    public HoloRotate rotate;
    public HoloZoom zoom;
    private HomePosition home;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Click();

    }

    public void Click()
    {
        Fang = GameObject.FindGameObjectWithTag("edifice");
        //光标看到的物体是fang就执行
        if (GazeManager.Instance.HitObject == Fang)
        {
            home = Fang.GetComponent<HomePosition>();
            home.enabled = true;
            if (Fang.GetComponent<HandDraggable>() == null && Fang.GetComponent<HoloZoom>() == null && Fang.GetComponent<HoloRotate>() == null)
            {
                move = Fang.AddComponent<HandDraggable>();
                move.enabled = false;
                zoom = Fang.AddComponent<HoloZoom>();
                zoom.enabled = false;
                rotate = Fang.AddComponent<HoloRotate>();
                rotate.enabled = false;
            }
            
        }
    }
    public void RotateWay()
    {
        rotate.enabled = true;
        move.enabled = false;
        zoom.enabled = false;

    }
    public void MoveWay()
    {
        move.enabled = true;
        rotate.enabled = false;
        zoom.enabled = false;
    }
    public void ZoomWay()
    {
        zoom.enabled = true;
        rotate.enabled = false;
        move.enabled = false;
    }

    public void GoHome()
    {
        home.Back();
        home.enabled = false;
        Destroy(move);
        Destroy(rotate);
        Destroy(zoom);
    }

    //public void Move()
    //{
    //    Destroy(move);
    //    Destroy(rotate);
    //    Destroy(zoom);
    //}
    
}
