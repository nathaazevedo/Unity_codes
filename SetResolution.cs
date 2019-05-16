using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    //=======================================
    // trocar resolucoes
    //=======================================
    //      1024 x 768 // 4:3
    //---------------------------------------
    //      1280 x 720 // 16:9
    //      1366 x 768 // 16:9
    //      1440 x 900 // 16:10
    //      1600 x 900 // 16:9
    //      1680 x 1050// 16:10
    //      1920 x 1080// 16:9
    //---------------------------------------
    //      2560 x 1080// 21:9 ultrawide
    //=======================================
    public void Resolution01()
    {
        Screen.SetResolution(1024, 768, true);
    }
    //=======================================
    public void Resolution02()
    {
        Screen.SetResolution(1280, 720, true);
    }
    //=======================================
    public void Resolution03()
    {
        Screen.SetResolution(1366, 768, true);
    }
    //=======================================
    public void Resolution04()
    {
        Screen.SetResolution(1440, 900, true);
    }
    //=======================================
    public void Resolution05()
    {
        Screen.SetResolution(1600, 900, true);
    }
    //=======================================
    public void Resolution06()
    {
        Screen.SetResolution(1680, 1050, true);
    }
    //=======================================
    public void Resolution07()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    //=======================================
    public void Resolution08()
    {
        Screen.SetResolution(2560, 1080, true);
    }
}
