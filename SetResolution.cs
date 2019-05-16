using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetResolution : MonoBehaviour {

    //=======================================
    //          Resolucoes
    //=======================================
    private int[,] resolutions = new int[,] { 
        {1024, 768},    // 4:3
        {1280, 720},    // 16:9
        {1366, 768},    // 16:9
        {1440, 900},    // 16:10
        {1600, 900},    // 16:9
        {1680, 1050},   // 16:10
        {1920, 1080},   // 16:9
        {2560, 1080}    // 21:9 ultrawide
    };
    //=======================================
    private Text configText;
    private int select = 0;

    void Start()
    {
        configText = this.gameObject.GetComponent<Text>();
        Screen.SetResolution(resolutions[select, 0], resolutions[select, 1], true);
    }

    void Update()
    {
        configText.text = "Set resolution: " + resolutions[ select, 0] + " x " + resolutions[ select, 1];

        if (Input.GetKeyDown("right") && select < (resolutions.Length/resolutions.Rank)-1) // Neste caso, 16/2 = 8 que é o numero de solucoes disponiveis
        {
            select++;
        }
        else if (Input.GetKeyDown("left") && select > 0)
        {
            select--;
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            Screen.SetResolution(resolutions[ select, 0], resolutions[ select, 1], true);
        } else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
