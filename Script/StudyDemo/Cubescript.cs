using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //物体下降
    public void Decline()
    {
        //获取物体上的刚体组件
        Rigidbody body = this.gameObject.AddComponent<Rigidbody>(); 
        //添加刚体
        body.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
}
