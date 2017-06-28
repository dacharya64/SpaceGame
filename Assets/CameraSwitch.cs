using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    // Use this for initialization

    Camera cam1;
    Camera cam2;

	void Start () {
        cam1 = this.GetComponent<Camera>();
        cam2 = GameObject.Find("RedCamera").GetComponent<Camera>();
        cam1.enabled = true;
        cam2.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }

    }
}
