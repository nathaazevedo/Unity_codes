using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

// Troca de scene aposto determinado tempo
// Coloque sua imagem splash na cena

public class SplashScreen : MonoBehaviour {

  public float duracao = 2;
  public string cena = "Menu";
  private float tempo = 0;
  
  void Start(){
//	Screen.SetResolution(1024, 768, true);	  
  }
	
  void Update () {
    tempo += 1 * Time.deltaTime;
		if (tempo >= duracao){
      SceneManager.LoadScene(cena); 
    }
  }
  
}
