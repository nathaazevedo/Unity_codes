using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class MenuButtonController : MonoBehaviour{

    // =======================================
    // This is a menu that works with
    // mouse and/or keyboard
    // =======================================
    // Crie os UI Buttons com os comandos 
    // de click e arraste para o array _button
    // =======================================

    public int index;
    public Button[] _button;
    private bool buttonSelected;
    private int maxIndex;
    //    public AudioSource audioSource;
    ColorBlock colorVar;

    void Start(){
        maxIndex = _button.Length-1; // n� max de opcoes � igual ao n� max de botoes
        colorVar = _button[index].colors;                 // pegar opcoes de cores do botao
        colorVar.normalColor = colorVar.highlightedColor; // mostrar que esta selecionado
        _button[index].colors = colorVar;                 // setar cor
    }

    void Update(){
        // Move
        if (Input.GetAxis("Vertical") != 0){
            colorVar = _button[index].colors;
            colorVar.normalColor = new Color(1, 1, 1);
            _button[index].colors = colorVar;
                if (!buttonSelected){
                if (Input.GetAxis("Vertical") < 0){
                    if (index < maxIndex){
                        index++;
                    } else {
                        index = 0;
                    }
                } else if (Input.GetAxis("Vertical") > 0) {
                    if (index > 0) {
                        index--;
                    } else {
                        index = maxIndex;
                    }
                }
                buttonSelected = true;
            }
        } else {
            buttonSelected = false;
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            _button[index].onClick.Invoke();
        }
        // Mouse Over
        if (EventSystem.current.IsPointerOverGameObject()){
            EventSystem eventSystem = EventSystem.current;
        //    Debug.Log(eventSystem.currentSelectedGameObject); // retorna o que foi clicado
            colorVar = _button[index].colors;
            colorVar.normalColor = new Color(1, 1, 1);
            _button[index].colors = colorVar;
        } else {
            // Selected
            colorVar.normalColor = colorVar.highlightedColor;
            _button[index].colors = colorVar;
        }
    }

    private void OnDisable() {
        buttonSelected = false;
    }

}
