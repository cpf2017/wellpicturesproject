using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HoloVoice : MonoBehaviour
{
    public GameObject fu;
    public GameObject a;
    public GameObject b;
    // Use this for initialization
    void Start () {

        fu = GameObject.Find("Gam");
        a = fu.transform.Find("A").gameObject;
        b = fu.transform.Find("B").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AandVoice()
    {
        a.SetActive(true);
        b.SetActive(false);
    }
    public void BandVoice()
    {
        a.SetActive(false);
        b.SetActive(true);
    }
}
