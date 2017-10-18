using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
//控制普通模型和高亮模型的隐藏和显示
public class Swop : MonoBehaviour {

    private GameObject edifice;
    private GameObject room;
    private GameObject model;
    private GameObject pan;
    // Use this for initialization
	void Start () {
        edifice = GameObject.Find("Edifice");
        room = edifice.transform.Find("room").gameObject;
        model = edifice.transform.Find("highlight_Model").gameObject;

        pan = GameObject.Find("panorama");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //显示普通建筑，隐藏高亮
    public void RoomOfVoice()
    {
        room.SetActive(true);
        model.SetActive(false);
        pan.SetActive(true);
        pan.SetActive(true);
    }
    //显示高亮隐藏普通建筑
    public void ModelOfVoice()
    {
        room.SetActive(false);
        model.SetActive(true);
        pan.SetActive(false);
    }
}
