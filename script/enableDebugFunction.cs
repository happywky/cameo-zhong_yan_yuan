using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDebugFunction : MonoBehaviour {
    public GameObject SM;
    // Use this for initialization

    void Start()
    {
        SM = GameObject.Find("SceneManager");
        SM.GetComponent<ScaleControlDebug>().objScaleControl = GameObject.Find("DebugControl");


        //SM.GetComponent<ScaleControlDebug>().dbUIBase.gameObject.SetActive(true);
        //SM.GetComponent<ScaleControlDebug>().dbPanel.gameObject.SetActive(true);

        SM.GetComponent<ScaleControlDebug>().resetPositionNScale(); //位置和縮放歸零
        SM.GetComponent<ScaleControlDebug>().FresetAll();   //顯示歸零后的參數
        SM.GetComponent<ScaleControlDebug>().hideDebugUI(); //隱藏DebugUI

        GameObject TOC = GameObject.Find("TriggerCameraRange");
        TOC.GetComponent<triggerOnCamera>().AtPrefabLoaded();

        SM.GetComponent<GYYLevelController>().showFly();

        Debug.Log("Run Start on Prefab Loaded");

    }
             
	
	// Update is called once per frame
	void Update () {
		
	}
}
