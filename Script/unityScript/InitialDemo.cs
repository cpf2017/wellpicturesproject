using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialDemo : MonoBehaviour {

    Vector3 pos;
    Quaternion rot;
    Vector3 scale;
    // Use this for initialization
  
    void Start () {
     
        pos = this.transform.position;
        rot = this.transform.rotation;
        scale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update() {

        //if (Input.GetKeyDown(KeyCode.N))
        //{
        //    Back();
        //}
    }

   public void Back()
    {
        this.gameObject.transform.position = pos;
        this.transform.rotation = rot;
        this.transform.localScale = scale;
    }

}
