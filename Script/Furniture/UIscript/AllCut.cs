using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;
using HoloToolkit.Unity;

public class AllCut : MonoBehaviour ,IInputClickHandler{

    private Tagalong move;
    private Billboard mian;
    private Transform all;
    private Transform chuang;
    private Transform zhuozi;
    private Transform yizi;
    private Transform shafa;
    private Transform chaji;
    private Transform shugui;
    private GameObject all_chuang;
    private GameObject all_zhuozi;
    private GameObject all_yizi;
    private GameObject all_shafa;
    private GameObject all_chaji;
    private GameObject all_shugui;
    private GameObject back_chaji;
    private GameObject back_chuang;
    private GameObject back_shugui;
    private GameObject back_shafa;
    private GameObject back_yizi;
    private GameObject back_zhuozi;

    private Transform suo1;
    private Transform suo2;

    void Start()
    {
        
        all = transform.Find("all");
        chuang = transform.Find("chuang");
        zhuozi = transform.Find("zhuozi");
        yizi = transform.Find("yizi");
        shafa = transform.Find("shafa");
        chaji = transform.Find("chaji");
        shugui = transform.Find("shugui");
        all_chuang = GameObject.Find("all/bian/all_bg/all_chuang");
        all_zhuozi = GameObject.Find("all/bian/all_bg/all_zhuozi");
        all_yizi = GameObject.Find("all/bian/all_bg/all_yizi");
        all_shafa = GameObject.Find("all/bian/all_bg/all_shafa");
        all_chaji = GameObject.Find("all/bian/all_bg/all_chaji");
        all_shugui = GameObject.Find("all/bian/all_bg/all_shugui");

        suo1 = transform.Find("suo1");
        suo2 = transform.Find("suo2");
        mian = GetComponent<Billboard>();
        move = GetComponent<Tagalong>();

       // print(all_chuang);
    }


    // Update is called once per frame
    void Update()
    {

    }

    void BackStart()
    {
        back_chaji = GameObject.Find("chaji/back_chaji");
        back_chuang = GameObject.Find("chuang/back_chuang");
        back_shugui = GameObject.Find("shugui/back_shugui");
        back_shafa = GameObject.Find("shafa/back_shafa");
        back_yizi = GameObject.Find("yizi/back_yizi");
        back_zhuozi = GameObject.Find("zhuozi/back_zhuozi");
    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        All_Chuang();
        All_zhuo();
        All_yizi();
        All_shafa();
        All_chaji();
        All_dianshigui();
        Back_chaji();
        Back_chuang();
        Back_shugui();
        Back_shafa();
        Back_yizi();
        Back_zhuozi();
        suo1_tap();
        suo2_tap();
    }

    void All_Chuang()
    {
        if(GazeManager.Instance.HitObject == all_chuang)
        {
            all.gameObject.SetActive(false);
            chuang.gameObject.SetActive(true);
            BackStart();
        }
    }
    void All_zhuo()
    {
        if (GazeManager.Instance.HitObject == all_zhuozi)
        {
            
            all.gameObject.SetActive(false);
            zhuozi.gameObject.SetActive(true);
            BackStart();
        }
    }
    void All_yizi()
    {
        if(GazeManager.Instance.HitObject == all_yizi)
        {
           
            all.gameObject.SetActive(false);
            yizi.gameObject.SetActive(true);
            BackStart();
        }
    }
    void All_shafa()
    {
        if(GazeManager.Instance.HitObject == all_shafa)
        {
           
            all.gameObject.SetActive(false);
            shafa.gameObject.SetActive(true);
            BackStart();
        }
    }
    void All_chaji()
    {
        if(GazeManager.Instance.HitObject == all_chaji)
        {
         
            all.gameObject.SetActive(false);
            chaji.gameObject.SetActive(true);
            BackStart();
        }
    }
    void All_dianshigui()
    {
        if (GazeManager.Instance.HitObject == all_shugui)
        {
          
            all.gameObject.SetActive(false);
            shugui.gameObject.SetActive(true);
            BackStart();
        }
    }
    void Back_chaji()
    {
        if (GazeManager.Instance.HitObject == back_chaji)
        {
            all.gameObject.SetActive(true);
            chaji.gameObject.SetActive(false);
        }
    }
    void Back_chuang()
    {
        if (GazeManager.Instance.HitObject == back_chuang)
        {
            all.gameObject.SetActive(true);
            chuang.gameObject.SetActive(false);
        }
    }
    void Back_shugui()
    {
        if (GazeManager.Instance.HitObject == back_shugui)
        {
            all.gameObject.SetActive(true);
            shugui.gameObject.SetActive(false);
        }
    }
    void Back_shafa()
    {
        if (GazeManager.Instance.HitObject == back_shafa)
        {
            all.gameObject.SetActive(true);
            shafa.gameObject.SetActive(false);
        }
    }
    void Back_yizi()
    {
        if (GazeManager.Instance.HitObject == back_yizi)
        {
            all.gameObject.SetActive(true);
            yizi.gameObject.SetActive(false);
        }
    }
    void Back_zhuozi()
    {
        if (GazeManager.Instance.HitObject == back_zhuozi)
        {
            all.gameObject.SetActive(true);
            zhuozi.gameObject.SetActive(false);
        }
    }

    void suo1_tap()
    {
        if(GazeManager.Instance.HitObject == suo1.gameObject)
        {
            mian.enabled = false;
            move.enabled = false;
            suo1.gameObject.SetActive(false);
            suo2.gameObject.SetActive(true);
        }
    }
    void suo2_tap()
    {
        if(GazeManager.Instance.HitObject == suo2.gameObject)
        {
            mian.enabled = true;
            move.enabled = true;
            suo1.gameObject.SetActive(true);
            suo2.gameObject.SetActive(false);
        }
    }
}
