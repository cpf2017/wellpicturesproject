using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;


public class HoloClick : MonoBehaviour ,IInputClickHandler
{
    //private GameObject cu;
    private HandDraggable move;
    private HoloRotate rotate;
    private HoloZoom zoom;
    private HomePosition home;
    private SphereCubeActive active;
    private List<HomePosition> homelist = new List<HomePosition>();
    private List<HandDraggable> movelist = new List<HandDraggable>();
    private List<HoloRotate> rotatelist = new List<HoloRotate>();
    private List<HoloZoom> zoomlist = new List<HoloZoom>();
    GameObject[] Fang;
    private GameObject scale;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        
        //只要点击就寻找标签为cube的物体
        Fang = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < Fang.Length; i++)
        {
            
            //当前正在被凝视的游戏对象等于点击的物体
            if (GazeManager.Instance.HitObject == Fang[i])
            {
               
                home = Fang[i].GetComponent<HomePosition>();
                home.enabled = true;
                homelist.Add(home);
                move = Fang[i].GetComponent<HandDraggable>();
                movelist.Add(move);
                zoom = Fang[i].GetComponent<HoloZoom>();
                zoomlist.Add(zoom);
                rotate = Fang[i].GetComponent<HoloRotate>();
                rotatelist.Add(rotate);
            }
        }
    }
    //旋转点击
    public void RotateWay()
    {
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = true;
        }
    }
    //移动点击
    public void MoveWay()
    {
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = true;
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
        }

    }
   //缩放点击
    public void ZoomWay()
    {
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
            
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = true;
            
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
            
        }
    }
    //将物体返回到初始状态
    public void Home()
    {
        for (int i = 0; i < homelist.Count; i++)
        {
            homelist[i].Back();
            homelist[i].enabled = false;
            homelist.Remove(homelist[i]);
        }
        for (int i = 0; i < movelist.Count; i++)
        {
            movelist[i].enabled = false;
            movelist.Remove(movelist[i]);
        }
        for (int i = 0; i < zoomlist.Count; i++)
        {
            zoomlist[i].enabled = false;
            zoomlist.Remove(zoomlist[i]);
        }
        for (int i = 0; i < rotatelist.Count; i++)
        {
            rotatelist[i].enabled = false;
            rotatelist.Remove(rotatelist[i]);
        }
    }
}
