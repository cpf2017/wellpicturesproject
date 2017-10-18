using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
public class RoomArea : MonoBehaviour {

    private Renderer chufang;
    private Renderer woshi;
    private Renderer ting;
    private Renderer yangtai;
    private Renderer cesuo;
    public GameObject chufang_di;
    private Transform chufang_zi;
    public GameObject woshi_di;
    private Transform woshi_zi_01;
    private Transform woshi_zi_02;
    private Transform woshi_zi_03;
    public GameObject ting_di;
    private Transform ting_zi;
    public GameObject yangtai_di;
    private Transform yangtai_zi;
    public GameObject cesuo_di;
    private Transform cesuo_zi;
	// Use this for initialization
	void Start () {
        chufang = chufang_di.GetComponent<Renderer>();
        woshi = woshi_di.GetComponent<Renderer>();
        ting = ting_di.GetComponent<Renderer>();
        yangtai = yangtai_di.GetComponent<Renderer>();
        cesuo = cesuo_di.GetComponent<Renderer>();
        chufang_zi = transform.Find("chufang_di/chufang_zi");
        woshi_zi_01 = transform.Find("woshi_di/woshi_zi_01");
        woshi_zi_02 = transform.Find("woshi_di/woshi_zi_02");
        woshi_zi_03 = transform.Find("woshi_di/woshi_zi_03");
        ting_zi = transform.Find("ting_di/ting_zi");
        yangtai_zi = transform.Find("yangtai_di/yangtai_zi");
        cesuo_zi = transform.Find("cesuo_di/cesuo_zi");
    }
	
	// Update is called once per frame
	void Update () {
        RoomAreaManager();

    }

    void RoomAreaManager()
    {
        if(GazeManager.Instance.HitObject == chufang_di)
        {
            chufang.material.color = Color.green;
            chufang_zi.gameObject.SetActive(true);
        }
        else
        {
            chufang.material.color = Color.white;
            chufang_zi.gameObject.SetActive(false);
        }

        if(GazeManager.Instance.HitObject == woshi_di)
        {
            woshi.material.color = Color.blue;
            woshi_zi_01.gameObject.SetActive(true);
            woshi_zi_02.gameObject.SetActive(true);
            woshi_zi_03.gameObject.SetActive(true);
        }
        else
        {
            woshi.material.color = Color.white;
            woshi_zi_01.gameObject.SetActive(false);
            woshi_zi_02.gameObject.SetActive(false);
            woshi_zi_03.gameObject.SetActive(false);
        }

        if(GazeManager.Instance.HitObject == ting_di)
        {
            ting.material.color = Color.yellow;
            ting_zi.gameObject.SetActive(true);
        }
        else
        {
            ting.material.color = Color.white;
            ting_zi.gameObject.SetActive(false);
        }
        if(GazeManager.Instance.HitObject == yangtai_di)
        {
            yangtai.material.color = Color.grey;
            yangtai_zi.gameObject.SetActive(true);
        }
        else
        {
            yangtai.material.color = Color.white;
            yangtai_zi.gameObject.SetActive(false);
        }
        if(GazeManager.Instance.HitObject == cesuo_di)
        {
            cesuo.material.color = Color.cyan;
            cesuo_zi.gameObject.SetActive(true);
        }
        else
        {
            cesuo.material.color = Color.white;
            cesuo_zi.gameObject.SetActive(false);
        }
    }
}
