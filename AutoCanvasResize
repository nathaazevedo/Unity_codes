using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCanvasResolution : MonoBehaviour
{
    private float scaleX;
    private float scaleY;

    private int resolutionBaseX = 1024;
    private int resolutionBaseY =  768;

    public bool attTela = false; // Ajustar a tela sempre, no update (true) | Apenas ajustar posicoes uma unica vez ao abrir a Scene (false)
    
    void Start(){
        scaleX = transform.localScale.x; // Pega a escala x atual do objeto
        scaleY = transform.localScale.y; // Pega a escala y atual do objeto

        transform.localScale = new Vector3((scaleX * Screen.width / resolutionBaseX), (scaleY * Screen.height / resolutionBaseY), transform.localScale.z);
    }

    void Update(){
        if (attTela == true) {
            transform.localScale = new Vector3((scaleX * Screen.width / resolutionBaseX), (scaleY * Screen.height / resolutionBaseY), transform.localScale.z);
        }
    }
}
