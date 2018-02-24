using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class Shafa_tap : MonoBehaviour, IInputClickHandler
{
    private GameObject shafa_01;
    private GameObject shafa_02;
    private GameObject shafa_03;
    private GameObject shafa_04;
    private GameObject shafa_05;
    private GameObject shafa_06;
    private GameObject sha;
    private GameObject Deleteob;
    // Use this for initialization
    void Start () {

        shafa_01 = GameObject.Find("shafa_01");
        shafa_02 = GameObject.Find("shafa_02");
        shafa_03 = GameObject.Find("shafa_03");
        shafa_04 = GameObject.Find("shafa_04");
        shafa_05 = GameObject.Find("shafa_05");
        shafa_06 = GameObject.Find("shafa_06");
        sha = Resources.Load("shafa") as GameObject;

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Shafa01_Show();
        Shafa02_Show();
        Shafa03_Show();
        Shafa04_Show();
        Shafa05_Show();
        Shafa06_Show();

    }

    void Shafa01_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_01)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha,shafa_01.transform.position,sha.transform.rotation);
        }
    }
    void Shafa02_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_02)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha, shafa_02.transform.position, sha.transform.rotation);
        }
    }
    void Shafa03_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_03)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha, shafa_03.transform.position, sha.transform.rotation);
        }
    }
    void Shafa04_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_04)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha, shafa_04.transform.position, sha.transform.rotation);
        }
    }
    void Shafa05_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_05)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha, shafa_05.transform.position, sha.transform.rotation);
        }
    }
    void Shafa06_Show()
    {
        if (GazeManager.Instance.HitObject == shafa_06)
        {
            //GameObject sha = Resources.Load("shafa") as GameObject;
            Instantiate(sha, shafa_06.transform.position, sha.transform.rotation);
        }
    }
    public void Deleteshafa()
    {
        Destroy(Deleteob);
    }
}
