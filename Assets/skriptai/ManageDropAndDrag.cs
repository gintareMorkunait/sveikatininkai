using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDropAndDrag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Drag()
    {
        GameObject.Find("Image0").transform.position = Input.mousePosition;
    }

    public void Drop()
    {
        GameObject ph1 = GameObject.Find("A3");
        float distance = Vector3.Distance(GameObject.Find("Image0").transform.position, ph1.transform.position);
        if (distance < 50)
        {
            GameObject.Find("Image0").transform.position = ph1.transform.position;
        }
    }
}
