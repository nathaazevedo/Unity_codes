using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public string loadScene;
    // Update is called once per frame
    void OnMouseUp()
    {
        SceneManager.LoadScene(loadScene);
    }
}
