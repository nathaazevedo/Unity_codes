using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCanvasResize : MonoBehaviour
{
    private float A;
    private float B;

    private float screenwidth;
    private float screenheight;

    public bool attTela = false; // Atualizar sempre a tela no update (true) | Apenas ajustar posicoes, uma unica vez (false)
    // Start is called before the first frame update
    void Start(){
        A = transform.localScale.x;
        B = transform.localScale.y;

        screenwidth = Screen.width;
        screenheight = Screen.height;

        transform.localScale = new Vector3((A * screenwidth / 1024), (B * screenheight / 768), transform.localScale.z);
    }

    // Update is called once per frame
    void Update(){
        if (attTela == true) {
            screenwidth = Screen.width;
            screenheight = Screen.height;

            transform.localScale = new Vector3((A * screenwidth / 1024), (B * screenheight / 768), transform.localScale.z);
        }
    }
}
