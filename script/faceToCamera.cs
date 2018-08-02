using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceToCamera : MonoBehaviour {

    GameObject targetCamera;
	// Use this for initialization
	void Start () {
        targetCamera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(targetCamera.transform);
	}
}
