using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFrame08 : MonoBehaviour
{
    public GameObject btn1stOn08;
    public GameObject btn2ndOn08;

    private void Start()
    {
        UI08hide();
    }

    public void UI08showUp()
    {

        btn1stOn08.SetActive(true);
        btn2ndOn08.SetActive(true);

    }

    public void UI08hide()
    {
        btn1stOn08.SetActive(false);
        btn2ndOn08.SetActive(false);
    }
}


