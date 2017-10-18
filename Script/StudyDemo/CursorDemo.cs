using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorDemo : MonoBehaviour {

    MeshRenderer cursor;
	// Use this for initialization
	void Start () {
        cursor = GetComponentInChildren<MeshRenderer>();
        cursor.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 headPosition = Camera.main.transform.position;
        Vector3 headDir = Camera.main.transform.forward;
        RaycastHit hitInfo;
        if(Physics.Raycast(headPosition,headDir,out hitInfo))
        {
            cursor.enabled = true;
            transform.position = hitInfo.point;
            transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
        else
        {
            cursor.enabled = false;
        }
	}
}
