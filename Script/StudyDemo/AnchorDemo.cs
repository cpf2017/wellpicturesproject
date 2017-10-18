using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA;

public class AnchorDemo : MonoBehaviour {

    public WorldAnchor anchor;
	// Use this for initialization
	void Start () {
        //WorldAnchor anchor = gameObject.AddComponent<WorldAnchor>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnAn()
    {
        WorldAnchor anchor = gameObject.AddComponent<WorldAnchor>();
    }
   public void OnAnchor()
    {
        DestroyImmediate(gameObject.GetComponent<WorldAnchor>());
    }

}
