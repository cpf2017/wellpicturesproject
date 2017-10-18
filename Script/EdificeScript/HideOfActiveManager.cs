using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class HideOfActiveManager : MonoBehaviour,IInputClickHandler {

    private HideOfActive active;
    private List<HideOfActive> activelist = new List<HideOfActive>();
    public GameObject[] wu;

    private HandDraggable move;
    private HoloRotate rotate;
    private HoloZoom zoom;
    private HomePosition home;
    private List<HomePosition> homelist = new List<HomePosition>();
    private List<HandDraggable> movelist = new List<HandDraggable>();
    private List<HoloRotate> rotatelist = new List<HoloRotate>();
    private List<HoloZoom> zoomlist = new List<HoloZoom>();
    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        

    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        //通过标签查找物体
        wu = GameObject.FindGameObjectsWithTag("highlight");
        for (int i = 0; i < wu.Length; i++)
        {
            //如果凝视到的物体是找到的物体
            if (GazeManager.Instance.HitObject == wu[i])
            {
                //获取其身上的脚本

                home = wu[i].GetComponent<HomePosition>();
                home.enabled = true;  //让脚本显示
                homelist.Add(home);  //将脚本添加到数组
                //如果物体上都没有这个脚本
                if (wu[i].GetComponent<HandDraggable>() == null && wu[i].GetComponent<HoloZoom>() == null && wu[i].GetComponent<HoloRotate>() == null)
                {
                    //就添加这个脚本，让他们都不激活，并且添加到数组                  
                     wu[i].AddComponent<HandDraggable>();//移动
                    
                    wu[i].AddComponent<HoloZoom>();//缩放
                    
                     wu[i].AddComponent<HoloRotate>();//旋转
                   
                }
                active = wu[i].GetComponent<HideOfActive>();
                activelist.Add(active);
                move = wu[i].GetComponent<HandDraggable>();
                move.enabled = false;
                movelist.Add(move);
                zoom = wu[i].GetComponent<HoloZoom>();
                zoom.enabled = false;
                zoomlist.Add(zoom);
                rotate = wu[i].GetComponent<HoloRotate>();
                rotate.enabled = false;
                rotatelist.Add(rotate);
            }
        }
    }
    //实现旋转
    public void RotateWa2()
    {
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = true;
        }
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
        }
    }
    //实现移动
    public void MoveWay2()
    {
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = true;
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
        }
    }
    //实现缩放
    public void ZoomWay2()
    {
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = true;
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
        }
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
        }
    }
    public void Remove2()
    {
            for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
            //zoomlist.Remove(zoomlist[i]);
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
            //rotatelist.Remove(rotatelist[i]);
        }
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
            //movelist.Remove(movelist[i]);
        }
    }
    public void GoBack2()
    {
        for (int i = 0; i < homelist.Count; i++)
        {
            homelist[i].Back();
            homelist[i].enabled = false;
            homelist.Remove(homelist[i]);
        }
        for (int i = 0; i < activelist.Count; i++)
        {
            activelist[i].Show();
            activelist[i].enabled = false;
            activelist.Remove(activelist[i]);
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            //Destroy(zoomlist[i]);
            zoomlist[i].enabled = false;
            zoomlist.Remove(zoomlist[i]);
            //Destroy(zoomlist[i]);
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            //Destroy(rotatelist[i]);
            rotatelist[i].enabled = false;
            rotatelist.Remove(rotatelist[i]);
            //Destroy(rotatelist[i]);
        }
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
            movelist.Remove(movelist[i]);
           //Destroy(movelist[i]);
        }
    }

    public void HideDemo()
    {
        for (int i = 0; i < activelist.Count; i++)
        {
            activelist[i].Hide();
        }
    }
    public void ShowDemo()
    {
        for (int i = 0; i < activelist.Count; i++)
        {
            activelist[i].Show();
        }
    }

  
}
