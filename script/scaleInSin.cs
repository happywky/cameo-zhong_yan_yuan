using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleInSin : MonoBehaviour {

    // Use this for initialization
    private GameObject emptyFrameGroup;
    private Vector3 scaleSin;
    private GameObject UImanager;

    void Start()
    {

        // this.gameObject.GetComponent<scaleInSin>().enabled = false;
        UImanager = GameObject.Find("SceneManager");
    }

    void OnEnable () 
    {
        emptyFrameGroup = this.transform.GetChild(0).gameObject;
        emptyFrameGroup.SetActive(false);
       
	}

    void OnDisable()
    {
        emptyFrameGroup.SetActive(false);
        emptyFrameGroup.transform.localScale = Vector3.one;
    }
	
	// Update is called once per frame
	void Update () {
        
        autoScale();
	}

    void autoScale()
    {
        for (int i = 0; i < 3; i++)
        {
            scaleSin[i] = 1.0f + 0.05f*Mathf.Sin(Time.time*10.0f); 
        }
        emptyFrameGroup.transform.localScale = scaleSin;
        
    }

    public void activeScriptSIS()
    {
        emptyFrameGroup.SetActive(true);   
    }

    public void deactiveScriptSIS()
    {
        emptyFrameGroup.SetActive(false);
    }


    void OnTriggerEnter(Collider targetEnter)
    {
        //.GetType() ==typeof(SphereCollider)
        if ((targetEnter is CapsuleCollider) && targetEnter.tag == "Player")
        { 
            activeScriptSIS();
            //show btn
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(false);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(false);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(false);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(false);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(false);

        }
    }

    void OnTriggerExit(Collider targetOut)
    {
        //.GetType() ==typeof(SphereCollider)
        if ((targetOut is CapsuleCollider) && targetOut.tag == "Player")
        {
            deactiveScriptSIS();

            //hide btn


            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[0].SetActive(true);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[1].SetActive(true);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[2].SetActive(true);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[3].SetActive(true);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[4].SetActive(true);
            UImanager.GetComponent<GYYLevelController>().selectFrameGroup[5].SetActive(true);
        }
    }

    
    }