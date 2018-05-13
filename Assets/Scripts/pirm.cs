using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pirm : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Drag1()
    {
        GameObject.Find("Image5").transform.position = Input.mousePosition;
    }

    public void Drop1()
    {
        GameObject ph1 = GameObject.Find("A1");
        float distance = Vector3.Distance(GameObject.Find("Image5").transform.position, ph1.transform.position);
        if (distance < 50)
        {
            GameObject.Find("Image5").transform.position = ph1.transform.position;
        }
    }
}
