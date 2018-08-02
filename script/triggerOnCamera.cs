using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class triggerOnCamera : MonoBehaviour {

    public GameObject GYYvideoPlayerHolder;

    //text Group
    public GameObject guiTestBeneathAnchor;



	// Use this for initialization
	void Start () {
       
        guiTestBeneathAnchor.GetComponent<Text>().text = "請將準心對準圖片中心完成掃描";
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider targetEnter)
	{
        //.GetType() ==typeof(SphereCollider)
        if ((targetEnter is SphereCollider) && targetEnter.tag == "SelectFrame")
        {
            guiTestBeneathAnchor.GetComponent<Text>().text = "恭喜你找到了其中一棟";

        }
	}


    void OnTriggerExit(Collider targetExit)
	{
        if (targetExit.tag == "movieTexture" || targetExit.tag == "SelectFrame")
        {
            

            //reset 按鈕文字然後隱藏按鈕
           


            //準心下方的文字 reset to "請對準有影片的大樓"
            guiTestBeneathAnchor.GetComponent<Text>().text = "找找看哪座大樓有影片";

            //Stop Screen's animation

            //make Screen back to rotation
            // faceTheCamera.enabled = false;
           // targetExit.GetComponent<faceToCamera>().enabled = false;
        }
	}


    public void AtPrefabLoaded()
    {
        guiTestBeneathAnchor.GetComponent<Text>().text = "找找看哪座大樓有影片";
    }


}
