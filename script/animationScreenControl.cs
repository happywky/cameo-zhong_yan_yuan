using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScreenControl : MonoBehaviour {

    Animation anim;
    faceToCamera faceTheCamera;
    Vector3 screenPositionReset;
    Quaternion screenRotationReset;

    bool readTransformAfterPlay = false;    //只读取一次参数
    bool ResetTransformWhenDoNotLookCamera = false; //只reset一次
	// Use this for initialization
	void Start () {

        screenPositionReset = GetComponent<Transform>().position;
        screenRotationReset = GetComponent<Transform>().rotation;

        anim = GetComponent<Animation>();
        anim.Play();
        faceTheCamera = GetComponent<faceToCamera>();
        faceTheCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(!anim.isPlaying && !faceTheCamera.enabled)
        {
            if(!readTransformAfterPlay)
            {
                screenPositionReset = GetComponent<Transform>().position;
                screenRotationReset = GetComponent<Transform>().rotation;
                Debug.Log(screenPositionReset);
                Debug.Log(screenRotationReset);
                readTransformAfterPlay = true;
            }

            if(ResetTransformWhenDoNotLookCamera)
            {
                transform.position = screenPositionReset;
                transform.rotation = screenRotationReset;
                ResetTransformWhenDoNotLookCamera = false;
            }

            transform.Rotate(0,2,0);

        }

        if(!anim.isPlaying && faceTheCamera.enabled)
        {
            //脚本被激活之后屏幕停止旋转并面朝向镜头
            ResetTransformWhenDoNotLookCamera = true;

        }
            
	}
}
