using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScaleControlDebug : MonoBehaviour {

    // Use this for initialization
    public GameObject objScaleControl;

    public GameObject dbUIBase;
    public GameObject dbUIScaleGroup;
    public GameObject dbUILocationHGroup;

    public Text scaleText;
    public Text PositionText;

    public Vector3 PosLast;
    public Vector3 ScaLast;

    public Vector3 PosNew;
    public Vector3 ScaNew;

    public GameObject btnShowBTN;
    public GameObject dbPanel;

	void Start () {

        //objScaleControl = GameObject.Find("DebugControl");

        dbUIBase.SetActive(true);
        dbPanel.SetActive(true);

        FresetAll();    //載入后記錄初始化數據
        hideDebugUI();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScaleUp()
    {
        float scaleTemp = ScaLast[0]; 
        for (int i = 0; i < 3; i++)
        {
            ScaNew[i] = scaleTemp+0.1f;
        }
        objScaleControl.transform.localScale = ScaNew;
        Debug.Log("Scale up to "+ScaNew);
        scaleText.text = ScaNew[0].ToString();
        ScaLast = ScaNew;
    }

    public void ScaleDown()
    {
        float scaleTemp = ScaLast[0];
        for (int i = 0; i < 3; i++)
        {
            ScaNew[i] = scaleTemp - 0.1f;
        }
        objScaleControl.transform.localScale = ScaNew;
        Debug.Log("Scale down to " + ScaNew);
        scaleText.text = ScaNew[0].ToString();
        ScaLast = ScaNew;
    }

    public void LocalXUP()
    {
        float posX = PosLast[0];

        PosNew[0] = posX + 0.10f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("X position add 1.0 to " + PosNew[0]);
        PositionText.text = PosNew[0].ToString() +" , "+ PosNew[1].ToString() + " , "+ PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void LocalXDown()
    {
        float posX = PosLast[0];

        PosNew[0] = posX - 0.10f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("X position minus 1.0 to " + PosNew[0]);
        PositionText.text = PosNew[0].ToString() + " , " + PosNew[1].ToString() + " , " + PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void LocalZUP()
    {
        float posZ = PosLast[2];

        PosNew[2] = posZ + 0.10f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("Z position add 1.0 to " + PosNew[2]);
        PositionText.text = PosNew[0].ToString() + " , " + PosNew[1].ToString() + " , " + PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void LocalZDown()
    {
        float posZ = PosLast[2];

        PosNew[2] = posZ - 0.10f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("Z position minus 1.0 to " + PosNew[2]);
        PositionText.text = PosNew[0].ToString() + " , " + PosNew[1].ToString() + " , " + PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void LocalYUP()
    {
        float posY = PosLast[1];

        PosNew[1] = posY + 0.050f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("Y position add 1.0 to " + PosNew[1]);
        PositionText.text = PosNew[0].ToString() + " , " + PosNew[1].ToString() + " , " + PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void LocalYDown()
    {
        float posY = PosLast[1];

        PosNew[1] = posY - 0.050f;

        objScaleControl.transform.position = PosNew;
        Debug.Log("Y position minus 1.0 to " + PosNew[1]);
        PositionText.text = PosNew[0].ToString() + " , " + PosNew[1].ToString() + " , " + PosNew[2].ToString();
        PosLast = PosNew;
    }

    public void FresetAll()
    {
        ScaLast = objScaleControl.transform.localScale;
        Debug.Log("ScaLast begin with " + ScaLast);

        PosLast = objScaleControl.transform.position;
        Debug.Log("ScaLast begin with " + PosLast);
        scaleText.text = ScaLast[0].ToString();
        PositionText.text = PosLast[0].ToString() + " , " + PosLast[1].ToString() + " , " + PosLast[2].ToString();

        objScaleControl.transform.rotation = Quaternion.identity;
    }

    public void hideDebugUI()
    {
        dbPanel.SetActive(false);
        btnShowBTN.SetActive(true);
               
    }

    public void showDebugUI()
    {
        dbPanel.SetActive(true);
        btnShowBTN.SetActive(false);
    }

    public void resetPositionNScale()
    {
        objScaleControl.transform.position = Vector3.zero;
        objScaleControl.transform.localScale = Vector3.one;

    }
}
