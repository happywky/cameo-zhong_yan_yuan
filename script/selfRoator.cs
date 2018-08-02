using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfRoator : MonoBehaviour {

	// Use this for initialization
    public float xSpeed, ySpeed, zSpeed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
       );
	}
}
