using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIenableWhenGotThisSingleton : MonoBehaviour {
    private GameObject UIParentAlreadyInTheScene;

    private GameObject TriggerCam;
	// Use this for initialization
	void Start () {
        TriggerCam = GameObject.Find("TriggerCameraRange");
        TriggerCam.GetComponent<triggerOnCamera>().AtPrefabLoaded();


        UIParentAlreadyInTheScene = GameObject.Find("SceneManager");
        UIParentAlreadyInTheScene.SetActive(true);


        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[0] = GameObject.Find("GroupSelectFrame06");
        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[1] = GameObject.Find("GroupSelectFrame12");
        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[2] = GameObject.Find("GroupSelectFrame18");
        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[3] = GameObject.Find("GroupSelectFrame21");
        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[4] = GameObject.Find("GroupSelectFrame31");
        UIParentAlreadyInTheScene.GetComponent<GYYLevelController>().selectFrameGroup[5] = GameObject.Find("GroupSelectFrame08");

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
