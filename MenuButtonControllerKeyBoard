using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonControllerKeyBoard : MonoBehaviour{

    // Use this for initialization
    public int index;
    private bool clicked;
    public int maxIndex;
    public AudioSource audioSource;
    public GameObject select;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        select.transform.position = new Vector2(select.transform.position.x, 284 + index * -75);
    }

    // Update is called once per frame
    void Update(){
        // Move
        if (Input.GetAxis("Vertical") != 0){
            if (!clicked){
                if (Input.GetAxis("Vertical") < 0){
                    if (index < maxIndex){
                        index++;
                    } else{
                        index = 0;
                    }
                } else if (Input.GetAxis("Vertical") > 0) {
                    if (index > 0){
                        index--;
                    } else {
                        index = maxIndex;
                    }
                }
                clicked = true;
            }
            select.transform.position = new Vector2(select.transform.position.x, 284 + index * -75);
        } else {
            clicked = false;
        }
        // Select
        /*
        if (Input.GetKeyDown(KeyCode.Return)){
            if (index == maxIndex){
                Application.Quit();
            }
        }
        */
    }

}
