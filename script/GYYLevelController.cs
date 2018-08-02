using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GYYLevelController : MonoBehaviour
{

    public GameObject StartUI;
    public GameObject ControlUI;

    public GameObject showBtnTop;
    public GameObject hideBtnTop;


    public GameObject Panel120H;


    public GameObject EmptyFlyGroup;

    public string videoNamePasses;
    private string videoName;

    public GameObject TriggerOnCam;


    public GameObject[] btnGroup;

    public GameObject[] CoverGroup;

    public GameObject[] selectFrameGroup;



    // Use this for initialization
    void Start()
    {
        StartUI.SetActive(true);
        ControlUI.SetActive(false);

        Panel120H.SetActive(false);

        hideBtnTop.SetActive(false);

        videoName = "";
        btnShowControlUI();
        hideFly();

        hideAllCoverGroups();
        hideAllCheckBtns();

    }

    // Update is called once per frame
    void Update()
    {

    }






    public void btnHideCoverPanel()
    {
        Panel120H.SetActive(false);

        StartUI.SetActive(true);
        ControlUI.SetActive(true);
        //show all selectFrame
        hideAllCoverGroups();

    }


    public void btnShowStartUI() { StartUI.SetActive(true); }

    public void btnHideStartUI() { StartUI.SetActive(false); }

    public void btnShowControlUI()
    {
        ControlUI.SetActive(true);  //顯示準心垂直圖層
        showBtnTop.SetActive(false);    //顯示按鈕“顯示界面”
        hideBtnTop.SetActive(true);     //顯示按鈕“隱藏界面”
        hideAllCheckBtns();     //隱藏右側“顯示Cover”的按鈕
    }

    public void btnHideControlUI()
    {
        ControlUI.SetActive(false);
        showBtnTop.SetActive(true);
        hideBtnTop.SetActive(false);
        hideAllCheckBtns();     //隱藏右側“顯示Cover”的按鈕
    }


    public void btnRestartLevel()
    {

        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void hideFly()
    {
        EmptyFlyGroup.SetActive(false);
    }

    public void showFly()
    {
        EmptyFlyGroup.SetActive(true);
    }


    public void hideAllCheckBtns()
    {
        //隱藏屏幕右側的“顯示Cover”按鈕
        for (int i = 0; i < 7; i++)
        {
            btnGroup[i].SetActive(false);
        }
    }


    #region CoverControl
    public void btnShowCoverPanel()
    {
        Panel120H.SetActive(true);

        StartUI.SetActive(false);
        ControlUI.SetActive(false);
        //hide all selectFrame
    }

    public void showCover06()
    {
        btnShowCoverPanel();
        CoverGroup[0].SetActive(true);

    }


    public void showCover12()
    {
        btnShowCoverPanel();
        CoverGroup[1].SetActive(true);
    }
    public void showCover18()
    {
        btnShowCoverPanel();
        CoverGroup[2].SetActive(true);
    }
    public void showCover21()
    {
        btnShowCoverPanel();
        CoverGroup[3].SetActive(true);
    }
    public void showCover31()
    {
        btnShowCoverPanel();
        CoverGroup[4].SetActive(true);
    }
    public void showCover08()
    {
        btnShowCoverPanel();
        CoverGroup[5].SetActive(true);
    }
    public void showCover60()
    {
        btnShowCoverPanel();
        CoverGroup[6].SetActive(true);
    }

    public void hideAllCoverGroups()
    {
        for (int i = 0; i < 7; i++)
        {
            CoverGroup[i].SetActive(false);
        }

        Panel120H.SetActive(false);
    }

    #endregion


    #region PlayVideoBtn
    public void playVideoBtn06()
    {
        Handheld.PlayFullScreenMovie("06.mp4", Color.black, FullScreenMovieControlMode.Full);
    }

    public void playVideoBtn08()
    {
        Handheld.PlayFullScreenMovie("08.mp4", Color.black, FullScreenMovieControlMode.Full);
    }

    public void playVideoBtn12()
    {
        Handheld.PlayFullScreenMovie("12.mp4", Color.black, FullScreenMovieControlMode.Full);
    }

    public void playVideoBtn18()
    {
        Handheld.PlayFullScreenMovie("18.mp4", Color.black, FullScreenMovieControlMode.Full);
    }

    public void playVideoBtn21()
    {
        Handheld.PlayFullScreenMovie("21.mp4", Color.black, FullScreenMovieControlMode.Full);
    }
    public void playVideoBtn31()
    {
        Handheld.PlayFullScreenMovie("31.mp4", Color.black, FullScreenMovieControlMode.Full);
    }
    public void playVideoBtn60()
    {
        Handheld.PlayFullScreenMovie("60.mp4", Color.black, FullScreenMovieControlMode.Full);
    }
#endregion


    #region SelectFrameGroups
    public void unHideSFGroups()
    {
        for (int i = 0; i < 6; i++)
        {
            selectFrameGroup[i].SetActive(false);
        }


    }

    public void hideOtherSFGroups(int hideNum)
    {
        for (int i = 0; i < 6; i++)
        {
            if (i == hideNum)
            {
                selectFrameGroup[i].SetActive(true);
            }
            else { selectFrameGroup[i].SetActive(false); }
        }
    }
#endregion
}
